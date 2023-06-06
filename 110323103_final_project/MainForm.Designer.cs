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
        private List<Object> ItemSelectInListBoxIntake;
        private List<Object> ItemSelectInListBoxExpenditure;
        string FilePath;
        string FileName;
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
            this.panelModify = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.textBoxModify = new System.Windows.Forms.TextBox();
            this.comboBoxModify = new System.Windows.Forms.ComboBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.labelIntake = new System.Windows.Forms.Label();
            this.labelExpenditure = new System.Windows.Forms.Label();
            this.listBoxExpenditure = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxIntake = new System.Windows.Forms.ListBox();
            this.labelOutNum = new System.Windows.Forms.Label();
            this.labelInNum = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelUnit = new System.Windows.Forms.Label();
            this.panelData.SuspendLayout();
            this.panelModify.SuspendLayout();
            this.panelTotal.SuspendLayout();
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
            this.buttonAdd.BackColor = System.Drawing.Color.Orange;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(29, 361);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 53);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "新增";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.SteelBlue;
            this.panelData.Controls.Add(this.panelTotal);
            this.panelData.Controls.Add(this.panelModify);
            this.panelData.Controls.Add(this.buttonModify);
            this.panelData.Controls.Add(this.labelIntake);
            this.panelData.Controls.Add(this.labelExpenditure);
            this.panelData.Controls.Add(this.listBoxExpenditure);
            this.panelData.Controls.Add(this.buttonRemove);
            this.panelData.Controls.Add(this.listBoxIntake);
            this.panelData.Controls.Add(this.buttonAdd);
            this.panelData.Location = new System.Drawing.Point(12, 112);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(954, 426);
            this.panelData.TabIndex = 7;
            this.panelData.Visible = false;
            // 
            // panelModify
            // 
            this.panelModify.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelModify.Controls.Add(this.labelUnit);
            this.panelModify.Controls.Add(this.buttonCancel);
            this.panelModify.Controls.Add(this.buttonConfirm);
            this.panelModify.Controls.Add(this.comboBoxSection);
            this.panelModify.Controls.Add(this.textBoxModify);
            this.panelModify.Controls.Add(this.comboBoxModify);
            this.panelModify.Location = new System.Drawing.Point(524, 45);
            this.panelModify.Name = "panelModify";
            this.panelModify.Size = new System.Drawing.Size(400, 209);
            this.panelModify.TabIndex = 0;
            this.panelModify.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(207, 141);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 53);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.Orange;
            this.buttonConfirm.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirm.Location = new System.Drawing.Point(85, 141);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(101, 53);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "確認";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(65, 40);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(121, 39);
            this.comboBoxSection.TabIndex = 2;
            this.comboBoxSection.SelectedIndexChanged += new System.EventHandler(this.comboBoxSection_SelectedIndexChanged);
            // 
            // textBoxModify
            // 
            this.textBoxModify.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModify.Location = new System.Drawing.Point(207, 40);
            this.textBoxModify.Name = "textBoxModify";
            this.textBoxModify.Size = new System.Drawing.Size(100, 38);
            this.textBoxModify.TabIndex = 1;
            this.textBoxModify.Visible = false;
            // 
            // comboBoxModify
            // 
            this.comboBoxModify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModify.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModify.FormattingEnabled = true;
            this.comboBoxModify.Location = new System.Drawing.Point(207, 39);
            this.comboBoxModify.Name = "comboBoxModify";
            this.comboBoxModify.Size = new System.Drawing.Size(121, 39);
            this.comboBoxModify.TabIndex = 0;
            this.comboBoxModify.Visible = false;
            // 
            // buttonModify
            // 
            this.buttonModify.BackColor = System.Drawing.Color.White;
            this.buttonModify.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.Color.Black;
            this.buttonModify.Location = new System.Drawing.Point(201, 361);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(101, 53);
            this.buttonModify.TabIndex = 12;
            this.buttonModify.Text = "修改";
            this.buttonModify.UseVisualStyleBackColor = false;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // labelIntake
            // 
            this.labelIntake.AutoSize = true;
            this.labelIntake.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntake.ForeColor = System.Drawing.Color.Transparent;
            this.labelIntake.Location = new System.Drawing.Point(23, 9);
            this.labelIntake.Name = "labelIntake";
            this.labelIntake.Size = new System.Drawing.Size(87, 33);
            this.labelIntake.TabIndex = 11;
            this.labelIntake.Text = "攝取 :";
            // 
            // labelExpenditure
            // 
            this.labelExpenditure.AutoSize = true;
            this.labelExpenditure.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenditure.ForeColor = System.Drawing.Color.Transparent;
            this.labelExpenditure.Location = new System.Drawing.Point(23, 186);
            this.labelExpenditure.Name = "labelExpenditure";
            this.labelExpenditure.Size = new System.Drawing.Size(87, 33);
            this.labelExpenditure.TabIndex = 10;
            this.labelExpenditure.Text = "消耗 :";
            // 
            // listBoxExpenditure
            // 
            this.listBoxExpenditure.BackColor = System.Drawing.Color.Azure;
            this.listBoxExpenditure.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExpenditure.FormattingEnabled = true;
            this.listBoxExpenditure.ItemHeight = 31;
            this.listBoxExpenditure.Location = new System.Drawing.Point(29, 222);
            this.listBoxExpenditure.Name = "listBoxExpenditure";
            this.listBoxExpenditure.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxExpenditure.Size = new System.Drawing.Size(450, 128);
            this.listBoxExpenditure.TabIndex = 9;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRemove.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRemove.Location = new System.Drawing.Point(378, 361);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(101, 53);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "移除";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxIntake
            // 
            this.listBoxIntake.BackColor = System.Drawing.Color.Azure;
            this.listBoxIntake.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIntake.FormattingEnabled = true;
            this.listBoxIntake.ItemHeight = 31;
            this.listBoxIntake.Location = new System.Drawing.Point(29, 45);
            this.listBoxIntake.Name = "listBoxIntake";
            this.listBoxIntake.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxIntake.Size = new System.Drawing.Size(450, 128);
            this.listBoxIntake.TabIndex = 7;
            // 
            // labelOutNum
            // 
            this.labelOutNum.AutoSize = true;
            this.labelOutNum.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutNum.ForeColor = System.Drawing.Color.Black;
            this.labelOutNum.Location = new System.Drawing.Point(228, 65);
            this.labelOutNum.Name = "labelOutNum";
            this.labelOutNum.Size = new System.Drawing.Size(60, 35);
            this.labelOutNum.TabIndex = 6;
            this.labelOutNum.Text = "???";
            // 
            // labelInNum
            // 
            this.labelInNum.AutoSize = true;
            this.labelInNum.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInNum.ForeColor = System.Drawing.Color.Black;
            this.labelInNum.Location = new System.Drawing.Point(228, 15);
            this.labelInNum.Name = "labelInNum";
            this.labelInNum.Size = new System.Drawing.Size(60, 35);
            this.labelInNum.TabIndex = 5;
            this.labelInNum.Text = "???";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOut.ForeColor = System.Drawing.Color.Black;
            this.labelOut.Location = new System.Drawing.Point(3, 65);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(216, 35);
            this.labelOut.TabIndex = 4;
            this.labelOut.Text = "消耗熱量總和 :";
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.ForeColor = System.Drawing.Color.Black;
            this.labelIn.Location = new System.Drawing.Point(3, 15);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(216, 35);
            this.labelIn.TabIndex = 3;
            this.labelIn.Text = "攝取熱量總和 :";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.labelIn);
            this.panelTotal.Controls.Add(this.labelOut);
            this.panelTotal.Controls.Add(this.labelInNum);
            this.panelTotal.Controls.Add(this.labelOutNum);
            this.panelTotal.Location = new System.Drawing.Point(524, 283);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(400, 114);
            this.panelTotal.TabIndex = 8;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit.ForeColor = System.Drawing.Color.Black;
            this.labelUnit.Location = new System.Drawing.Point(313, 41);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(60, 35);
            this.labelUnit.TabIndex = 7;
            this.labelUnit.Text = "???";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
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
            this.panelModify.ResumeLayout(false);
            this.panelModify.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
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
        private System.Windows.Forms.Label labelOutNum;
        private System.Windows.Forms.Label labelInNum;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxIntake;
        private System.Windows.Forms.ListBox listBoxExpenditure;
        private System.Windows.Forms.Label labelIntake;
        private System.Windows.Forms.Label labelExpenditure;
        private System.Windows.Forms.Panel panelModify;
        private System.Windows.Forms.ComboBox comboBoxModify;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.TextBox textBoxModify;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelUnit;
    }
}

