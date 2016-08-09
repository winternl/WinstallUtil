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
            this.components = new System.ComponentModel.Container();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.cbTaskTypes = new System.Windows.Forms.ComboBox();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.panSchedTask = new System.Windows.Forms.Panel();
            this.btnRemoveTrigger = new System.Windows.Forms.Button();
            this.btnAddTrigger = new System.Windows.Forms.Button();
            this.lvTriggers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSchedTaskPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSchedTaskName = new System.Windows.Forms.TextBox();
            this.panCreateUser = new System.Windows.Forms.Panel();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAccVerifyPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccPassword = new System.Windows.Forms.TextBox();
            this.lbl0 = new System.Windows.Forms.Label();
            this.txtAccUsername = new System.Windows.Forms.TextBox();
            this.panInstall = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrowseInstall = new System.Windows.Forms.Button();
            this.txtInstallerPath = new System.Windows.Forms.TextBox();
            this.panCopyDir = new System.Windows.Forms.Panel();
            this.chkHiddenDirCopy = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCopyDir = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCopyDirDest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEmbedDirectory = new System.Windows.Forms.Button();
            this.txtEmbedDir = new System.Windows.Forms.TextBox();
            this.panCopyFile = new System.Windows.Forms.Panel();
            this.chkHiddenFileCopy = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCopyFileRoot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCopyFileDest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmbedFile = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.btnCreateTask = new System.Windows.Forms.Button();
            this.btnTestTask = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpParameters.SuspendLayout();
            this.panSchedTask.SuspendLayout();
            this.panCreateUser.SuspendLayout();
            this.panInstall.SuspendLayout();
            this.panCopyDir.SuspendLayout();
            this.panCopyFile.SuspendLayout();
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
            this.txtTaskName.MaxLength = 64;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(257, 23);
            this.txtTaskName.TabIndex = 0;
            // 
            // cbTaskTypes
            // 
            this.cbTaskTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskTypes.FormattingEnabled = true;
            this.cbTaskTypes.Location = new System.Drawing.Point(15, 132);
            this.cbTaskTypes.Name = "cbTaskTypes";
            this.cbTaskTypes.Size = new System.Drawing.Size(257, 23);
            this.cbTaskTypes.Sorted = true;
            this.cbTaskTypes.TabIndex = 2;
            // 
            // grpParameters
            // 
            this.grpParameters.Controls.Add(this.panSchedTask);
            this.grpParameters.Controls.Add(this.panCreateUser);
            this.grpParameters.Controls.Add(this.panInstall);
            this.grpParameters.Controls.Add(this.panCopyDir);
            this.grpParameters.Controls.Add(this.panCopyFile);
            this.grpParameters.Location = new System.Drawing.Point(15, 172);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(257, 249);
            this.grpParameters.TabIndex = 4;
            this.grpParameters.TabStop = false;
            this.grpParameters.Text = "Task Parameters";
            // 
            // panSchedTask
            // 
            this.panSchedTask.Controls.Add(this.btnRemoveTrigger);
            this.panSchedTask.Controls.Add(this.btnAddTrigger);
            this.panSchedTask.Controls.Add(this.lvTriggers);
            this.panSchedTask.Controls.Add(this.label10);
            this.panSchedTask.Controls.Add(this.label11);
            this.panSchedTask.Controls.Add(this.txtSchedTaskPath);
            this.panSchedTask.Controls.Add(this.label12);
            this.panSchedTask.Controls.Add(this.txtSchedTaskName);
            this.panSchedTask.Location = new System.Drawing.Point(6, 22);
            this.panSchedTask.Name = "panSchedTask";
            this.panSchedTask.Size = new System.Drawing.Size(245, 221);
            this.panSchedTask.TabIndex = 12;
            this.panSchedTask.Visible = false;
            // 
            // btnRemoveTrigger
            // 
            this.btnRemoveTrigger.Location = new System.Drawing.Point(205, 148);
            this.btnRemoveTrigger.Name = "btnRemoveTrigger";
            this.btnRemoveTrigger.Size = new System.Drawing.Size(20, 23);
            this.btnRemoveTrigger.TabIndex = 15;
            this.btnRemoveTrigger.Text = "-";
            this.toolTip1.SetToolTip(this.btnRemoveTrigger, "Remove selected trigger");
            this.btnRemoveTrigger.UseVisualStyleBackColor = true;
            this.btnRemoveTrigger.Click += new System.EventHandler(this.btnRemoveTrigger_Click);
            // 
            // btnAddTrigger
            // 
            this.btnAddTrigger.Location = new System.Drawing.Point(205, 119);
            this.btnAddTrigger.Name = "btnAddTrigger";
            this.btnAddTrigger.Size = new System.Drawing.Size(20, 23);
            this.btnAddTrigger.TabIndex = 14;
            this.btnAddTrigger.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddTrigger, "Add trigger");
            this.btnAddTrigger.UseVisualStyleBackColor = true;
            this.btnAddTrigger.Click += new System.EventHandler(this.btnAddTrigger_Click);
            // 
            // lvTriggers
            // 
            this.lvTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTriggers.FullRowSelect = true;
            this.lvTriggers.GridLines = true;
            this.lvTriggers.Location = new System.Drawing.Point(17, 119);
            this.lvTriggers.Name = "lvTriggers";
            this.lvTriggers.Size = new System.Drawing.Size(182, 81);
            this.lvTriggers.TabIndex = 13;
            this.lvTriggers.UseCompatibleStateImageBehavior = false;
            this.lvTriggers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Trigger";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Triggers:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Program to Run:";
            // 
            // txtSchedTaskPath
            // 
            this.txtSchedTaskPath.Location = new System.Drawing.Point(17, 75);
            this.txtSchedTaskPath.MaxLength = 256;
            this.txtSchedTaskPath.Name = "txtSchedTaskPath";
            this.txtSchedTaskPath.PasswordChar = '•';
            this.txtSchedTaskPath.Size = new System.Drawing.Size(208, 23);
            this.txtSchedTaskPath.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtSchedTaskPath, "Path to the program to run on task");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Task Name:";
            // 
            // txtSchedTaskName
            // 
            this.txtSchedTaskName.Location = new System.Drawing.Point(17, 31);
            this.txtSchedTaskName.MaxLength = 256;
            this.txtSchedTaskName.Name = "txtSchedTaskName";
            this.txtSchedTaskName.Size = new System.Drawing.Size(208, 23);
            this.txtSchedTaskName.TabIndex = 0;
            // 
            // panCreateUser
            // 
            this.panCreateUser.Controls.Add(this.chkAdmin);
            this.panCreateUser.Controls.Add(this.label8);
            this.panCreateUser.Controls.Add(this.txtAccVerifyPassword);
            this.panCreateUser.Controls.Add(this.label7);
            this.panCreateUser.Controls.Add(this.txtAccPassword);
            this.panCreateUser.Controls.Add(this.lbl0);
            this.panCreateUser.Controls.Add(this.txtAccUsername);
            this.panCreateUser.Location = new System.Drawing.Point(6, 22);
            this.panCreateUser.Name = "panCreateUser";
            this.panCreateUser.Size = new System.Drawing.Size(245, 221);
            this.panCreateUser.TabIndex = 11;
            this.panCreateUser.Visible = false;
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.Location = new System.Drawing.Point(126, 158);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(99, 19);
            this.chkAdmin.TabIndex = 13;
            this.chkAdmin.Text = "Administrator";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Verify Password:";
            // 
            // txtAccVerifyPassword
            // 
            this.txtAccVerifyPassword.Location = new System.Drawing.Point(17, 119);
            this.txtAccVerifyPassword.MaxLength = 256;
            this.txtAccVerifyPassword.Name = "txtAccVerifyPassword";
            this.txtAccVerifyPassword.PasswordChar = '•';
            this.txtAccVerifyPassword.Size = new System.Drawing.Size(208, 23);
            this.txtAccVerifyPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password:";
            // 
            // txtAccPassword
            // 
            this.txtAccPassword.Location = new System.Drawing.Point(17, 75);
            this.txtAccPassword.MaxLength = 256;
            this.txtAccPassword.Name = "txtAccPassword";
            this.txtAccPassword.PasswordChar = '•';
            this.txtAccPassword.Size = new System.Drawing.Size(208, 23);
            this.txtAccPassword.TabIndex = 9;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(14, 13);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(63, 15);
            this.lbl0.TabIndex = 8;
            this.lbl0.Text = "Username:";
            // 
            // txtAccUsername
            // 
            this.txtAccUsername.Location = new System.Drawing.Point(17, 31);
            this.txtAccUsername.MaxLength = 256;
            this.txtAccUsername.Name = "txtAccUsername";
            this.txtAccUsername.Size = new System.Drawing.Size(208, 23);
            this.txtAccUsername.TabIndex = 0;
            // 
            // panInstall
            // 
            this.panInstall.Controls.Add(this.checkBox1);
            this.panInstall.Controls.Add(this.label9);
            this.panInstall.Controls.Add(this.btnBrowseInstall);
            this.panInstall.Controls.Add(this.txtInstallerPath);
            this.panInstall.Location = new System.Drawing.Point(6, 22);
            this.panInstall.Name = "panInstall";
            this.panInstall.Size = new System.Drawing.Size(245, 221);
            this.panInstall.TabIndex = 10;
            this.panInstall.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Silent Install";
            this.toolTip1.SetToolTip(this.checkBox1, "This feature will only work if the installer support a silent command line argume" +
        "nt.");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Embed Installer:";
            // 
            // btnBrowseInstall
            // 
            this.btnBrowseInstall.Location = new System.Drawing.Point(176, 60);
            this.btnBrowseInstall.Name = "btnBrowseInstall";
            this.btnBrowseInstall.Size = new System.Drawing.Size(49, 23);
            this.btnBrowseInstall.TabIndex = 8;
            this.btnBrowseInstall.Text = "...";
            this.btnBrowseInstall.UseVisualStyleBackColor = true;
            this.btnBrowseInstall.Click += new System.EventHandler(this.btnBrowseInstall_Click);
            // 
            // txtInstallerPath
            // 
            this.txtInstallerPath.Location = new System.Drawing.Point(17, 31);
            this.txtInstallerPath.MaxLength = 1024;
            this.txtInstallerPath.Name = "txtInstallerPath";
            this.txtInstallerPath.Size = new System.Drawing.Size(208, 23);
            this.txtInstallerPath.TabIndex = 0;
            // 
            // panCopyDir
            // 
            this.panCopyDir.Controls.Add(this.chkHiddenDirCopy);
            this.panCopyDir.Controls.Add(this.label4);
            this.panCopyDir.Controls.Add(this.cbCopyDir);
            this.panCopyDir.Controls.Add(this.label5);
            this.panCopyDir.Controls.Add(this.txtCopyDirDest);
            this.panCopyDir.Controls.Add(this.label6);
            this.panCopyDir.Controls.Add(this.btnEmbedDirectory);
            this.panCopyDir.Controls.Add(this.txtEmbedDir);
            this.panCopyDir.Location = new System.Drawing.Point(6, 22);
            this.panCopyDir.Name = "panCopyDir";
            this.panCopyDir.Size = new System.Drawing.Size(245, 221);
            this.panCopyDir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.panCopyDir, "Everything after the root directory. \"File.exe or Directory\\File.exe\"\r\n");
            this.panCopyDir.Visible = false;
            // 
            // chkHiddenDirCopy
            // 
            this.chkHiddenDirCopy.AutoSize = true;
            this.chkHiddenDirCopy.Location = new System.Drawing.Point(80, 186);
            this.chkHiddenDirCopy.Name = "chkHiddenDirCopy";
            this.chkHiddenDirCopy.Size = new System.Drawing.Size(145, 19);
            this.chkHiddenDirCopy.TabIndex = 9;
            this.chkHiddenDirCopy.Text = "Apply hidden attribute";
            this.chkHiddenDirCopy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Destination Path:";
            this.toolTip1.SetToolTip(this.label4, "The destination directory\'s path after the root directory.");
            // 
            // cbCopyDir
            // 
            this.cbCopyDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCopyDir.FormattingEnabled = true;
            this.cbCopyDir.Location = new System.Drawing.Point(17, 104);
            this.cbCopyDir.Name = "cbCopyDir";
            this.cbCopyDir.Size = new System.Drawing.Size(208, 23);
            this.cbCopyDir.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cbCopyDir, "Root directory to copy the directory to.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination Root:";
            this.toolTip1.SetToolTip(this.label5, "Root directory to copy the directory to.");
            // 
            // txtCopyDirDest
            // 
            this.txtCopyDirDest.Location = new System.Drawing.Point(17, 157);
            this.txtCopyDirDest.MaxLength = 200;
            this.txtCopyDirDest.Name = "txtCopyDirDest";
            this.txtCopyDirDest.Size = new System.Drawing.Size(208, 23);
            this.txtCopyDirDest.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCopyDirDest, "The destination directory\'s path after the root directory.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Embed Directory:";
            // 
            // btnEmbedDirectory
            // 
            this.btnEmbedDirectory.Location = new System.Drawing.Point(176, 60);
            this.btnEmbedDirectory.Name = "btnEmbedDirectory";
            this.btnEmbedDirectory.Size = new System.Drawing.Size(49, 23);
            this.btnEmbedDirectory.TabIndex = 8;
            this.btnEmbedDirectory.Text = "...";
            this.btnEmbedDirectory.UseVisualStyleBackColor = true;
            this.btnEmbedDirectory.Click += new System.EventHandler(this.btnEmbedDirectory_Click);
            // 
            // txtEmbedDir
            // 
            this.txtEmbedDir.Location = new System.Drawing.Point(17, 31);
            this.txtEmbedDir.MaxLength = 1024;
            this.txtEmbedDir.Name = "txtEmbedDir";
            this.txtEmbedDir.Size = new System.Drawing.Size(208, 23);
            this.txtEmbedDir.TabIndex = 0;
            // 
            // panCopyFile
            // 
            this.panCopyFile.Controls.Add(this.chkHiddenFileCopy);
            this.panCopyFile.Controls.Add(this.label3);
            this.panCopyFile.Controls.Add(this.cbCopyFileRoot);
            this.panCopyFile.Controls.Add(this.label2);
            this.panCopyFile.Controls.Add(this.txtCopyFileDest);
            this.panCopyFile.Controls.Add(this.label1);
            this.panCopyFile.Controls.Add(this.button1);
            this.panCopyFile.Controls.Add(this.txtEmbedFile);
            this.panCopyFile.Location = new System.Drawing.Point(6, 22);
            this.panCopyFile.Name = "panCopyFile";
            this.panCopyFile.Size = new System.Drawing.Size(245, 221);
            this.panCopyFile.TabIndex = 8;
            this.panCopyFile.Visible = false;
            // 
            // chkHiddenFileCopy
            // 
            this.chkHiddenFileCopy.AutoSize = true;
            this.chkHiddenFileCopy.Location = new System.Drawing.Point(80, 186);
            this.chkHiddenFileCopy.Name = "chkHiddenFileCopy";
            this.chkHiddenFileCopy.Size = new System.Drawing.Size(145, 19);
            this.chkHiddenFileCopy.TabIndex = 9;
            this.chkHiddenFileCopy.Text = "Apply hidden attribute";
            this.chkHiddenFileCopy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Destination Path:";
            this.toolTip1.SetToolTip(this.label3, "Everything after the root directory. \"File.exe or Directory\\File.exe\"\r\n");
            // 
            // cbCopyFileRoot
            // 
            this.cbCopyFileRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCopyFileRoot.FormattingEnabled = true;
            this.cbCopyFileRoot.Location = new System.Drawing.Point(17, 104);
            this.cbCopyFileRoot.Name = "cbCopyFileRoot";
            this.cbCopyFileRoot.Size = new System.Drawing.Size(208, 23);
            this.cbCopyFileRoot.TabIndex = 8;
            this.toolTip1.SetToolTip(this.cbCopyFileRoot, "Root directory to copy the file to.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Destination Root:";
            this.toolTip1.SetToolTip(this.label2, "Root directory to copy the file to.");
            // 
            // txtCopyFileDest
            // 
            this.txtCopyFileDest.Location = new System.Drawing.Point(17, 157);
            this.txtCopyFileDest.MaxLength = 200;
            this.txtCopyFileDest.Name = "txtCopyFileDest";
            this.txtCopyFileDest.Size = new System.Drawing.Size(208, 23);
            this.txtCopyFileDest.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCopyFileDest, "Everything after the root directory. \"File.exe or Directory\\File.exe\"\r\n");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Embed File:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmbedFile
            // 
            this.txtEmbedFile.Location = new System.Drawing.Point(17, 31);
            this.txtEmbedFile.MaxLength = 1024;
            this.txtEmbedFile.Name = "txtEmbedFile";
            this.txtEmbedFile.Size = new System.Drawing.Size(208, 23);
            this.txtEmbedFile.TabIndex = 0;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Location = new System.Drawing.Point(15, 76);
            this.txtTaskDescription.MaxLength = 1024;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(257, 23);
            this.txtTaskDescription.TabIndex = 1;
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
            this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
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
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(15, 427);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(53, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 462);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnTestTask);
            this.Controls.Add(this.btnCreateTask);
            this.Controls.Add(this.txtTaskDescription);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.grpParameters);
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
            this.grpParameters.ResumeLayout(false);
            this.panSchedTask.ResumeLayout(false);
            this.panSchedTask.PerformLayout();
            this.panCreateUser.ResumeLayout(false);
            this.panCreateUser.PerformLayout();
            this.panInstall.ResumeLayout(false);
            this.panInstall.PerformLayout();
            this.panCopyDir.ResumeLayout(false);
            this.panCopyDir.PerformLayout();
            this.panCopyFile.ResumeLayout(false);
            this.panCopyFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ComboBox cbTaskTypes;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Button btnCreateTask;
        private System.Windows.Forms.Button btnTestTask;
        private System.Windows.Forms.Panel panCopyFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmbedFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCopyFileRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCopyFileDest;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.CheckBox chkHiddenFileCopy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panCopyDir;
        private System.Windows.Forms.CheckBox chkHiddenDirCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCopyDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCopyDirDest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEmbedDirectory;
        private System.Windows.Forms.TextBox txtEmbedDir;
        private System.Windows.Forms.Panel panInstall;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBrowseInstall;
        private System.Windows.Forms.TextBox txtInstallerPath;
        private System.Windows.Forms.Panel panCreateUser;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAccVerifyPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccPassword;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.TextBox txtAccUsername;
        private System.Windows.Forms.Panel panSchedTask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSchedTaskPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSchedTaskName;
        private System.Windows.Forms.Button btnRemoveTrigger;
        private System.Windows.Forms.Button btnAddTrigger;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView lvTriggers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}