namespace _110323103_final_project
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public string NewItem;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelRemark = new System.Windows.Forms.Label();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.panelRemark = new System.Windows.Forms.Panel();
            this.panelValue = new System.Windows.Forms.Panel();
            this.panelItem = new System.Windows.Forms.Panel();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panelRemark.SuspendLayout();
            this.panelValue.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownHeight = 200;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.IntegralHeight = false;
            this.comboBoxType.ItemHeight = 31;
            this.comboBoxType.Items.AddRange(new object[] {
            "攝取",
            "消耗"});
            this.comboBoxType.Location = new System.Drawing.Point(121, 49);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(151, 39);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Black;
            this.labelType.Location = new System.Drawing.Point(28, 52);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(87, 33);
            this.labelType.TabIndex = 5;
            this.labelType.Text = "類型 :";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownHeight = 200;
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.IntegralHeight = false;
            this.comboBoxItem.ItemHeight = 31;
            this.comboBoxItem.Location = new System.Drawing.Point(109, 0);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(151, 39);
            this.comboBoxItem.TabIndex = 6;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.ForeColor = System.Drawing.Color.Black;
            this.labelItem.Location = new System.Drawing.Point(16, 3);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(87, 33);
            this.labelItem.TabIndex = 7;
            this.labelItem.Text = "項目 :";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.ForeColor = System.Drawing.Color.Black;
            this.labelValue.Location = new System.Drawing.Point(16, 3);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(87, 33);
            this.labelValue.TabIndex = 8;
            this.labelValue.Text = "數值 :";
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemark.ForeColor = System.Drawing.Color.Black;
            this.labelRemark.Location = new System.Drawing.Point(16, 3);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(87, 33);
            this.labelRemark.TabIndex = 10;
            this.labelRemark.Text = "備註 :";
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemark.Location = new System.Drawing.Point(109, 0);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(151, 38);
            this.textBoxRemark.TabIndex = 11;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit.ForeColor = System.Drawing.Color.Black;
            this.labelUnit.Location = new System.Drawing.Point(266, 3);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(73, 33);
            this.labelUnit.TabIndex = 12;
            this.labelUnit.Text = "單位";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(109, 0);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(151, 38);
            this.textBoxValue.TabIndex = 13;
            // 
            // panelRemark
            // 
            this.panelRemark.Controls.Add(this.labelRemark);
            this.panelRemark.Controls.Add(this.textBoxRemark);
            this.panelRemark.Location = new System.Drawing.Point(12, 209);
            this.panelRemark.Name = "panelRemark";
            this.panelRemark.Size = new System.Drawing.Size(355, 38);
            this.panelRemark.TabIndex = 14;
            this.panelRemark.Visible = false;
            // 
            // panelValue
            // 
            this.panelValue.Controls.Add(this.labelValue);
            this.panelValue.Controls.Add(this.labelUnit);
            this.panelValue.Controls.Add(this.textBoxValue);
            this.panelValue.Location = new System.Drawing.Point(12, 155);
            this.panelValue.Name = "panelValue";
            this.panelValue.Size = new System.Drawing.Size(355, 38);
            this.panelValue.TabIndex = 15;
            this.panelValue.Visible = false;
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.labelItem);
            this.panelItem.Controls.Add(this.comboBoxItem);
            this.panelItem.Location = new System.Drawing.Point(12, 106);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(355, 43);
            this.panelItem.TabIndex = 16;
            this.panelItem.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonConfirm.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(121, 283);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(124, 44);
            this.buttonConfirm.TabIndex = 8;
            this.buttonConfirm.Text = "確認";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(379, 339);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panelValue);
            this.Controls.Add(this.panelRemark);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Name = "AddForm";
            this.Text = "新增資料";
            this.panelRemark.ResumeLayout(false);
            this.panelRemark.PerformLayout();
            this.panelValue.ResumeLayout(false);
            this.panelValue.PerformLayout();
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Panel panelRemark;
        private System.Windows.Forms.Panel panelValue;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Button buttonConfirm;
    }
}