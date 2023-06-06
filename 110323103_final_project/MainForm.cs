using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ManagementTaskProject;

namespace _110323103_final_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            FilePath = "..//..//Data//";
            LoadFileFlag = false;
        }
        private void comboBoxDate__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(comboBoxYear))
            {
                comboBoxMonth.Enabled = true;
            }
            else if (sender.Equals(comboBoxMonth))
            {
                comboBoxDay.Enabled = true;
            }
            else if (sender.Equals(comboBoxDay))
            {
                panelData.Visible = true;
                LoadFileFlag = true;
            }
            LoadFile_Task(LoadFileFlag);
        }

        private void LoadFile_Task(bool Flag)
        {
            if (Flag)
            {
                listBoxIntake.Items.Clear();
                listBoxExpenditure.Items.Clear();
                CurMgmtTask = new ManagementTask();
                FileName = FilePath + comboBoxYear.Text + "_" + comboBoxMonth.Text + "_" + comboBoxDay.Text + ".txt";
                CurMgmtTask.LoadTaskFile(FileName);
                Item_to_ListBox();
            }
        }

        private void Item_to_ListBox() // 將文字檔所有的項目依照攝取與消耗分成兩部分，並顯示至2對應的listBox
        {
            double totalIntake = 0, totalExpenditure = 0;
            ItemSelectInListBoxIntake = CurMgmtTask.Item.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Intake); });
            foreach (Object CurItem in ItemSelectInListBoxIntake)
            {
                Intake CurIntake = (Intake)CurItem;
                listBoxIntake.Items.Add("    " + CurIntake.Name + " : " + CurIntake.Calories + "大卡, " + CurIntake.Remark);
                totalIntake += CurIntake.Calories;
            }
            ItemSelectInListBoxExpenditure = CurMgmtTask.Item.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Expenditure); });
            foreach (Object CurItem in ItemSelectInListBoxExpenditure)
            {
                Expenditure CurExpenditure = (Expenditure)CurItem;
                CurExpenditure.Calories = CurExpenditure.Compute();
                listBoxExpenditure.Items.Add("    " + CurExpenditure.Name + " : " + CurExpenditure.Time + "分鐘, " + (int)CurExpenditure.Calories + "大卡");
                totalExpenditure += CurExpenditure.Calories;
            }
            labelInNum.Text = totalIntake.ToString() + "  大卡";
            labelOutNum.Text = ((int)totalExpenditure).ToString() + "  大卡";
            Refresh();
        }

        private void Rewrite_File() // 將listBox顯示的所有項目重新寫至該文字檔
        {
            FileStream RewriteFile = new FileStream(FileName, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(RewriteFile);
            foreach (Intake CurItem in ItemSelectInListBoxIntake)
                sw.WriteLine("攝取 : " + CurItem.Name + " " + CurItem.Calories.ToString() + " " + CurItem.Remark);
            foreach (Expenditure CurItem in ItemSelectInListBoxExpenditure)
                sw.WriteLine("消耗 : " + CurItem.Name + " " + CurItem.Time.ToString());
            sw.Flush();
            sw.Close();
            RewriteFile.Close();
        }

        private void CurAddForm__FormClosedInMainForm(object sender, EventArgs e) // 將新增的項目加至對應的listBox => 更新文字檔 => 重新讀取更新後的檔案
        {
            AddForm CurAddForm = (AddForm)sender;
            NewItemInMainForm = CurAddForm.NewItem;
            if(NewItemInMainForm != null)
            {
                CurMgmtTask.Add_daily_item(NewItemInMainForm);
                Item_to_ListBox();
                Rewrite_File();
                LoadFile_Task(LoadFileFlag);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm CurAddForm = new AddForm();
            CurAddForm.Show();
            CurAddForm.FormClosed += new FormClosedEventHandler(CurAddForm__FormClosedInMainForm);
        }

        private void buttonRemove_Click(object sender, EventArgs e) // 刪除清單中所有被選取之項目 => 更新文字檔 => 重新讀取更新後的檔案
        {
            if ((listBoxIntake.SelectedIndices.Count + listBoxExpenditure.SelectedIndices.Count) == 0)
            {
                MessageBox.Show("請選擇要刪除的項目!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            for (int i = 0; i < listBoxIntake.SelectedIndices.Count; i++)
                ItemSelectInListBoxIntake.RemoveAt(listBoxIntake.SelectedIndices[i]);
            for (int i = 0; i < listBoxExpenditure.SelectedIndices.Count; i++)
                ItemSelectInListBoxExpenditure.RemoveAt(listBoxExpenditure.SelectedIndices[i]);
            Rewrite_File();
            LoadFile_Task(LoadFileFlag);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if ((listBoxIntake.SelectedIndices.Count + listBoxExpenditure.SelectedIndices.Count) == 0)
            {
                MessageBox.Show("請選擇一個要修改的項目!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if ((listBoxIntake.SelectedIndices.Count + listBoxExpenditure.SelectedIndices.Count) != 1)
            {
                MessageBox.Show("一次只能修改一個項目!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }  
            comboBoxSection.Items.Clear();
            comboBoxModify.Visible = false;
            textBoxModify.Visible = false;
            labelUnit.Visible = false;
            if (listBoxIntake.SelectedIndices.Count == 1)
                comboBoxSection.Items.AddRange(new object[] { "項目", "熱量", "備註" });
            else
                comboBoxSection.Items.AddRange(new object[] { "項目", "時間" });
            panelModify.Visible = true;
        }

        private void comboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModify.Items.Clear();
            textBoxModify.Text = null;
            comboBoxModify.Visible = false;
            textBoxModify.Visible = false;
            labelUnit.Visible = false;
            if (comboBoxSection.Text == "項目")
            {
                if (listBoxIntake.SelectedIndices.Count == 1)
                    comboBoxModify.Items.AddRange(new object[] { "早餐", "午餐", "晚餐", "飲料", "甜點" });
                else
                    comboBoxModify.Items.AddRange(new object[] { "走路", "慢跑", "游泳", "騎腳踏車" });
                comboBoxModify.Visible = true;
            }
            else
            {
                if (comboBoxSection.Text == "熱量")
                    labelUnit.Text = "大卡";
                else if (comboBoxSection.Text == "時間")
                    labelUnit.Text = "分鐘";
                else if (comboBoxSection.Text == "備註")
                    labelUnit.Text = "  ";
                labelUnit.Visible = true;
                textBoxModify.Visible = true;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            float itemValue = 0;
            if (comboBoxSection.Text == "")
            {
                MessageBox.Show("請選擇項目!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if ((comboBoxSection.Text == "熱量" || comboBoxSection.Text == "時間") && !float.TryParse(textBoxModify.Text, out itemValue))
            {
                MessageBox.Show("請輸入數值!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = comboBoxModify.Text;
            if (textBoxModify.Visible == true)
                result = textBoxModify.Text;

            if (listBoxIntake.SelectedIndices.Count == 1)
            {
                Intake TargetItem = (Intake)ItemSelectInListBoxIntake[listBoxIntake.SelectedIndex];
                ItemSelectInListBoxIntake[listBoxIntake.SelectedIndex] = TargetItem ^ (comboBoxSection.Text + ":" + result);
            }
            else
            {
                Expenditure TargetItem = (Expenditure)ItemSelectInListBoxExpenditure[listBoxExpenditure.SelectedIndex];
                ItemSelectInListBoxExpenditure[listBoxExpenditure.SelectedIndex] = TargetItem ^ (comboBoxSection.Text + ":" + result);
            }
            panelModify.Visible = false;
            Rewrite_File();
            LoadFile_Task(LoadFileFlag);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelModify.Visible = false;
        }
    }
}
