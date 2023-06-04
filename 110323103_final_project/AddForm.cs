using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _110323103_final_project
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelItem.Visible = true;
            if(comboBoxType.Text == "攝取")
            {
                comboBoxItem.Items.Clear();
                comboBoxItem.Items.AddRange(new object[] { "早餐", "午餐", "晚餐", "飲料", "甜點" });
                labelValue.Text = "熱量";
                labelUnit.Text = "大卡";
                panelValue.Visible = true;
                panelRemark.Visible = true;
            }
            else if(comboBoxType.Text == "消耗")
            {
                labelValue.Text = "時間";
                labelUnit.Text = "分鐘";
                panelValue.Visible = true;
                panelRemark.Visible = false;
                comboBoxItem.Items.Clear();
                comboBoxItem.Items.AddRange(new object[] { "走路", "慢跑", "游泳", "騎腳踏車"});
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //error check
            if (comboBoxType.Text == "攝取")
                NewItem = "Intake   (" + comboBoxItem.Text + ", " + textBoxValue.Text + ", " + textBoxRemark.Text + ")";
            else if (comboBoxType.Text == "消耗")
                NewItem = "Expenditure   (" + comboBoxItem.Text + ", " + textBoxValue.Text + ")";
            this.Close();
        }
    }
}
