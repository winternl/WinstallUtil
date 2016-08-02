namespace WinstallUI
{
    partial class FormSchedTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSchedTaskType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numHR = new System.Windows.Forms.NumericUpDown();
            this.numMN = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.grpDateTime = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMN)).BeginInit();
            this.grpDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trigger Type:";
            // 
            // cbSchedTaskType
            // 
            this.cbSchedTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchedTaskType.FormattingEnabled = true;
            this.cbSchedTaskType.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "On logon",
            "At startup",
            "On idle"});
            this.cbSchedTaskType.Location = new System.Drawing.Point(15, 41);
            this.cbSchedTaskType.Name = "cbSchedTaskType";
            this.cbSchedTaskType.Size = new System.Drawing.Size(227, 23);
            this.cbSchedTaskType.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 217);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(62, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Ok";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hour:";
            // 
            // numHR
            // 
            this.numHR.Location = new System.Drawing.Point(61, 31);
            this.numHR.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numHR.Name = "numHR";
            this.numHR.Size = new System.Drawing.Size(44, 23);
            this.numHR.TabIndex = 5;
            // 
            // numMN
            // 
            this.numMN.Location = new System.Drawing.Point(165, 31);
            this.numMN.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numMN.Name = "numMN";
            this.numMN.Size = new System.Drawing.Size(44, 23);
            this.numMN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minute:";
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbDay.Location = new System.Drawing.Point(61, 73);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(148, 23);
            this.cbDay.TabIndex = 8;
            // 
            // grpDateTime
            // 
            this.grpDateTime.Controls.Add(this.label4);
            this.grpDateTime.Controls.Add(this.cbDay);
            this.grpDateTime.Controls.Add(this.numMN);
            this.grpDateTime.Controls.Add(this.label3);
            this.grpDateTime.Controls.Add(this.label2);
            this.grpDateTime.Controls.Add(this.numHR);
            this.grpDateTime.Location = new System.Drawing.Point(15, 85);
            this.grpDateTime.Name = "grpDateTime";
            this.grpDateTime.Size = new System.Drawing.Size(227, 126);
            this.grpDateTime.TabIndex = 9;
            this.grpDateTime.TabStop = false;
            this.grpDateTime.Text = "Time + Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Day:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(112, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSchedTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpDateTime);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbSchedTaskType);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 300);
            this.Name = "FormSchedTask";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.numHR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMN)).EndInit();
            this.grpDateTime.ResumeLayout(false);
            this.grpDateTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSchedTaskType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHR;
        private System.Windows.Forms.NumericUpDown numMN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.GroupBox grpDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
    }
}