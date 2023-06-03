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

            if (LoadFileFlag)
            {
                CurMgmtTask = new ManagementTask();
                string FileName = FilePath + comboBoxYear.Text + "_" + comboBoxMonth.Text + "_" + comboBoxDay.Text + ".txt";
                CurMgmtTask.LoadTaskFile(FileName);


                ItemSelectInListBox = CurMgmtTask.Item.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Intake); });
                foreach (Object CurItem in ItemSelectInListBox)
                {
                    Intake CurIntake = (Intake)CurItem;
                    listBoxItem.Items.Add("Intake   (" + CurIntake.Name + ", " + CurIntake.Calories + ", " + CurIntake.Remark + ")");
                }
                ItemSelectInListBox = CurMgmtTask.Item.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Expenditure); });
                foreach(Object CurItem in ItemSelectInListBox)
                {
                    Expenditure CurExpenditure = (Expenditure)CurItem;
                    listBoxItem.Items.Add("Expenditure   (" + CurExpenditure.Name + ", " + CurExpenditure.Time +  ")");
                }
            }
        }
    }
}
