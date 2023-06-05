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
            float itemValue = 0;
            ErrorCodes errorType = ErrorCodes.NONE;
            if (comboBoxType.Text == "")
                errorType = ErrorCodes.WRONG_TYPE;
            else if (comboBoxItem.Text == "")
                errorType = ErrorCodes.WRONG_ITEM;
            else if (!float.TryParse(textBoxValue.Text, out itemValue))
                errorType = ErrorCodes.WRONG_VALUE;

            Show_Error_Message(errorType);

            if (errorType == ErrorCodes.NONE)
            {
                if (comboBoxType.Text == "攝取")
                {
                    if (textBoxRemark.Text == "")
                        textBoxRemark.Text = "無";
                    NewItem = "攝取 : " + comboBoxItem.Text + " " + textBoxValue.Text + " " + textBoxRemark.Text;
                }
                else if (comboBoxType.Text == "消耗")
                {
                    NewItem = "消耗 : " + comboBoxItem.Text + " " + textBoxValue.Text;
                }
                this.Close();
            }
        }

        private void Show_Error_Message(ErrorCodes errorType)
        {
            switch (errorType)
            {
                case ErrorCodes.NONE:
                    break;
                case ErrorCodes.WRONG_TYPE:
                    MessageBox.Show("請選擇類型!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.WRONG_ITEM:
                    MessageBox.Show("請選擇項目!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.WRONG_VALUE:
                    MessageBox.Show("請輸入數值!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
