namespace WinstallUI
{
    partial class FormTask
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
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.cbTaskTypes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnTestTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(12, 9);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(42, 15);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "Name:";
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(12, 114);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(63, 15);
            this.lblTaskType.TabIndex = 1;
            this.lblTaskType.Text = "Task Type:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(15, 27);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(257, 23);
            this.txtTaskName.TabIndex = 2;
            // 
            // cbTaskTypes
            // 
            this.cbTaskTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskTypes.FormattingEnabled = true;
            this.cbTaskTypes.Location = new System.Drawing.Point(15, 132);
            this.cbTaskTypes.Name = "cbTaskTypes";
            this.cbTaskTypes.Size = new System.Drawing.Size(257, 23);
            this.cbTaskTypes.Sorted = true;
            this.cbTaskTypes.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 249);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Parameters";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(15, 76);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(257, 23);
            this.txtTaskDescription.TabIndex = 6;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(12, 58);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(70, 15);
            this.lblTaskDescription.TabIndex = 5;
            this.lblTaskDescription.Text = "Description:";
            // 
            // btnCreateTask
            // 
            this.btnCreateTask.Location = new System.Drawing.Point(197, 427);
            this.btnCreateTask.Name = "btnCreateTask";
            this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTask.TabIndex = 0;
            this.btnCreateTask.Text = "Create";
            this.btnCreateTask.UseVisualStyleBackColor = true;
            // 
            // btnTestTask
            // 
            this.btnTestTask.Location = new System.Drawing.Point(74, 427);
            this.btnTestTask.Name = "btnTestTask";
            this.btnTestTask.Size = new System.Drawing.Size(117, 23);
            this.btnTestTask.TabIndex = 7;
            this.btnTestTask.Text = "Verify Module";
            this.btnTestTask.UseVisualStyleBackColor = true;
            this.btnTestTask.Click += new System.EventHandler(this.btnTestTask_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.btnTestTask);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTaskTypes);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblTaskName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTask";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ComboBox cbTaskTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnTestTask;
    }
}