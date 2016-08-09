namespace WinstallUI
{
    partial class FormMain
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
            this.lvTaskItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btnOpenExisting = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTaskItems
            // 
            this.lvTaskItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvTaskItems.FullRowSelect = true;
            this.lvTaskItems.GridLines = true;
            this.lvTaskItems.Location = new System.Drawing.Point(12, 80);
            this.lvTaskItems.Name = "lvTaskItems";
            this.lvTaskItems.Size = new System.Drawing.Size(660, 370);
            this.lvTaskItems.TabIndex = 0;
            this.lvTaskItems.UseCompatibleStateImageBehavior = false;
            this.lvTaskItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 461;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnOpenExisting
            // 
            this.btnOpenExisting.Location = new System.Drawing.Point(113, 51);
            this.btnOpenExisting.Name = "btnOpenExisting";
            this.btnOpenExisting.Size = new System.Drawing.Size(95, 23);
            this.btnOpenExisting.TabIndex = 2;
            this.btnOpenExisting.Text = "Open Existing";
            this.btnOpenExisting.UseVisualStyleBackColor = true;
            this.btnOpenExisting.Click += new System.EventHandler(this.btnOpenExisting_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(516, 51);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(597, 51);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTask.TabIndex = 4;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnOpenExisting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvTaskItems);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WInstall UI";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOpenExisting;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        public System.Windows.Forms.ListView lvTaskItems;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}