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
            for (int i = 0; i < listBoxIntake.SelectedIndices.Count; i++)
                ItemSelectInListBoxIntake.RemoveAt(listBoxIntake.SelectedIndices[i]);
            for (int i = 0; i < listBoxExpenditure.SelectedIndices.Count; i++)
                ItemSelectInListBoxExpenditure.RemoveAt(listBoxExpenditure.SelectedIndices[i]);
            Rewrite_File();
            LoadFile_Task(LoadFileFlag);
        }
    }
}
