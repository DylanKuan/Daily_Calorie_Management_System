using ManagementTaskProject;
using System.Collections.Generic;
using System;

namespace _110323103_final_project
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ManagementTask CurMgmtTask;
        private List<Object> ItemSelectInListBox;
        string FilePath;
        bool LoadFileFlag;
        public string NewItemInMainForm;
        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxItem = new System.Windows.Forms.ListBox();
            this.labelResNum = new System.Windows.Forms.Label();
            this.labelInNum = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.textBoxBMR = new System.Windows.Forms.TextBox();
            this.labelBMR = new System.Windows.Forms.Label();
            this.openFileDialogLoad = new System.Windows.Forms.OpenFileDialog();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(135, 50);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(44, 33);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "年";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.Black;
            this.labelDay.Location = new System.Drawing.Point(423, 50);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(44, 33);
            this.labelDay.TabIndex = 1;
            this.labelDay.Text = "日";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.ForeColor = System.Drawing.Color.Black;
            this.labelMonth.Location = new System.Drawing.Point(279, 50);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(44, 33);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "月";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownHeight = 200;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.IntegralHeight = false;
            this.comboBoxYear.ItemHeight = 31;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.comboBoxYear.Location = new System.Drawing.Point(41, 47);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(88, 39);
            this.comboBoxYear.TabIndex = 3;
            this.comboBoxYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate__SelectedIndexChanged);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownHeight = 200;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Enabled = false;
            this.comboBoxMonth.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.IntegralHeight = false;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonth.Location = new System.Drawing.Point(185, 47);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(88, 39);
            this.comboBoxMonth.TabIndex = 4;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate__SelectedIndexChanged);
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.DropDownHeight = 200;
            this.comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDay.Enabled = false;
            this.comboBoxDay.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.IntegralHeight = false;
            this.comboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(329, 47);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(88, 39);
            this.comboBoxDay.TabIndex = 5;
            this.comboBoxDay.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate__SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(66, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 53);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "新增";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.buttonRemove);
            this.panelData.Controls.Add(this.listBoxItem);
            this.panelData.Controls.Add(this.buttonAdd);
            this.panelData.Controls.Add(this.labelResNum);
            this.panelData.Controls.Add(this.labelInNum);
            this.panelData.Controls.Add(this.labelRes);
            this.panelData.Controls.Add(this.labelIn);
            this.panelData.Controls.Add(this.textBoxBMR);
            this.panelData.Controls.Add(this.labelBMR);
            this.panelData.Location = new System.Drawing.Point(12, 110);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(954, 426);
            this.panelData.TabIndex = 7;
            this.panelData.Visible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.Location = new System.Drawing.Point(273, 350);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(101, 53);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "移除";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // listBoxItem
            // 
            this.listBoxItem.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItem.FormattingEnabled = true;
            this.listBoxItem.ItemHeight = 31;
            this.listBoxItem.Location = new System.Drawing.Point(29, 81);
            this.listBoxItem.Name = "listBoxItem";
            this.listBoxItem.Size = new System.Drawing.Size(384, 252);
            this.listBoxItem.TabIndex = 7;
            // 
            // labelResNum
            // 
            this.labelResNum.AutoSize = true;
            this.labelResNum.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResNum.ForeColor = System.Drawing.Color.Black;
            this.labelResNum.Location = new System.Drawing.Point(759, 328);
            this.labelResNum.Name = "labelResNum";
            this.labelResNum.Size = new System.Drawing.Size(57, 33);
            this.labelResNum.TabIndex = 6;
            this.labelResNum.Text = "???";
            // 
            // labelInNum
            // 
            this.labelInNum.AutoSize = true;
            this.labelInNum.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInNum.ForeColor = System.Drawing.Color.Black;
            this.labelInNum.Location = new System.Drawing.Point(759, 256);
            this.labelInNum.Name = "labelInNum";
            this.labelInNum.Size = new System.Drawing.Size(57, 33);
            this.labelInNum.TabIndex = 5;
            this.labelInNum.Text = "???";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRes.ForeColor = System.Drawing.Color.Black;
            this.labelRes.Location = new System.Drawing.Point(569, 328);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(145, 33);
            this.labelRes.TabIndex = 4;
            this.labelRes.Text = "剩餘熱量 :";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.ForeColor = System.Drawing.Color.Black;
            this.labelIn.Location = new System.Drawing.Point(553, 256);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(174, 33);
            this.labelIn.TabIndex = 3;
            this.labelIn.Text = "已攝取熱量 :";
            // 
            // textBoxBMR
            // 
            this.textBoxBMR.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBMR.Location = new System.Drawing.Point(742, 177);
            this.textBoxBMR.Name = "textBoxBMR";
            this.textBoxBMR.Size = new System.Drawing.Size(100, 38);
            this.textBoxBMR.TabIndex = 2;
            // 
            // labelBMR
            // 
            this.labelBMR.AutoSize = true;
            this.labelBMR.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMR.ForeColor = System.Drawing.Color.Black;
            this.labelBMR.Location = new System.Drawing.Point(553, 180);
            this.labelBMR.Name = "labelBMR";
            this.labelBMR.Size = new System.Drawing.Size(174, 33);
            this.labelBMR.TabIndex = 1;
            this.labelBMR.Text = "基礎代謝率 :";
            // 
            // openFileDialogLoad
            // 
            this.openFileDialogLoad.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelYear);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "每日熱量紀錄系統";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label labelResNum;
        private System.Windows.Forms.Label labelInNum;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.TextBox textBoxBMR;
        private System.Windows.Forms.Label labelBMR;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoad;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxItem;
    }
}

