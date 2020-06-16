namespace UNCCStudentIDHolder
{
    partial class FRM_UNCCStudentIDs
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
            this.MNUSTRIP_Bar = new System.Windows.Forms.MenuStrip();
            this.MNUSTRP_Program = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUSTRP_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUSTRP_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUSTRP_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.MNUSTRP_About = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Search = new System.Windows.Forms.Button();
            this.GRPBOX_Users = new System.Windows.Forms.GroupBox();
            this.LST_Entries = new System.Windows.Forms.ListBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Edit = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_View = new System.Windows.Forms.Button();
            this.TABCTRL_Controls = new System.Windows.Forms.TabControl();
            this.TABPAGE_Welcome = new System.Windows.Forms.TabPage();
            this.TABCTRL_Main = new System.Windows.Forms.TabControl();
            this.TABPAGE_Add = new System.Windows.Forms.TabPage();
            this.RAD_No = new System.Windows.Forms.RadioButton();
            this.LBL_ActiveUser = new System.Windows.Forms.Label();
            this.RAD_Yes = new System.Windows.Forms.RadioButton();
            this.LBL_EnterID = new System.Windows.Forms.Label();
            this.TXT_IDInput = new System.Windows.Forms.TextBox();
            this.TXT_NameInput = new System.Windows.Forms.TextBox();
            this.LBL_EnterName = new System.Windows.Forms.Label();
            this.TABPAGE_Search = new System.Windows.Forms.TabPage();
            this.RAD_ID = new System.Windows.Forms.RadioButton();
            this.LBLSearchName = new System.Windows.Forms.Label();
            this.LBL_SearchType = new System.Windows.Forms.Label();
            this.TXT_SearchInput = new System.Windows.Forms.TextBox();
            this.RAD_Name = new System.Windows.Forms.RadioButton();
            this.TABPAGE_Login = new System.Windows.Forms.TabPage();
            this.LBL_WelcomeText = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.LBL_EnterPassword = new System.Windows.Forms.Label();
            this.TXT_PasswordInput = new System.Windows.Forms.TextBox();
            this.TXT_UsernameInput = new System.Windows.Forms.TextBox();
            this.LBL_EnterUsername = new System.Windows.Forms.Label();
            this.MNUSTRIP_Bar.SuspendLayout();
            this.GRPBOX_Users.SuspendLayout();
            this.TABCTRL_Controls.SuspendLayout();
            this.TABPAGE_Welcome.SuspendLayout();
            this.TABCTRL_Main.SuspendLayout();
            this.TABPAGE_Add.SuspendLayout();
            this.TABPAGE_Search.SuspendLayout();
            this.TABPAGE_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // MNUSTRIP_Bar
            // 
            this.MNUSTRIP_Bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUSTRP_Program,
            this.fileToolStripMenuItem,
            this.MNUSTRP_About});
            this.MNUSTRIP_Bar.Location = new System.Drawing.Point(0, 0);
            this.MNUSTRIP_Bar.Name = "MNUSTRIP_Bar";
            this.MNUSTRIP_Bar.Size = new System.Drawing.Size(673, 24);
            this.MNUSTRIP_Bar.TabIndex = 0;
            this.MNUSTRIP_Bar.Text = "menuStrip1";
            // 
            // MNUSTRP_Program
            // 
            this.MNUSTRP_Program.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUSTRP_Restart,
            this.MNUSTRP_Exit});
            this.MNUSTRP_Program.Name = "MNUSTRP_Program";
            this.MNUSTRP_Program.Size = new System.Drawing.Size(65, 20);
            this.MNUSTRP_Program.Text = "Program";
            // 
            // MNUSTRP_Restart
            // 
            this.MNUSTRP_Restart.Name = "MNUSTRP_Restart";
            this.MNUSTRP_Restart.Size = new System.Drawing.Size(110, 22);
            this.MNUSTRP_Restart.Text = "Restart";
            this.MNUSTRP_Restart.Click += new System.EventHandler(this.MNUSTRP_Restart_Click);
            // 
            // MNUSTRP_Exit
            // 
            this.MNUSTRP_Exit.Name = "MNUSTRP_Exit";
            this.MNUSTRP_Exit.Size = new System.Drawing.Size(110, 22);
            this.MNUSTRP_Exit.Text = "Exit";
            this.MNUSTRP_Exit.Click += new System.EventHandler(this.MNUSTRP_Exit_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNUSTRP_Export});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // MNUSTRP_Export
            // 
            this.MNUSTRP_Export.Name = "MNUSTRP_Export";
            this.MNUSTRP_Export.Size = new System.Drawing.Size(128, 22);
            this.MNUSTRP_Export.Text = "Export as..";
            this.MNUSTRP_Export.Click += new System.EventHandler(this.MNUSTRP_Export_Click);
            // 
            // MNUSTRP_About
            // 
            this.MNUSTRP_About.Name = "MNUSTRP_About";
            this.MNUSTRP_About.Size = new System.Drawing.Size(52, 20);
            this.MNUSTRP_About.Text = "About";
            this.MNUSTRP_About.Click += new System.EventHandler(this.MNUSTRP_About_Click);
            // 
            // BTN_Search
            // 
            this.BTN_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Search.Location = new System.Drawing.Point(539, 8);
            this.BTN_Search.Name = "BTN_Search";
            this.BTN_Search.Size = new System.Drawing.Size(118, 23);
            this.BTN_Search.TabIndex = 3;
            this.BTN_Search.Text = "Search";
            this.BTN_Search.UseVisualStyleBackColor = true;
            this.BTN_Search.Click += new System.EventHandler(this.BTN_Search_Click);
            // 
            // GRPBOX_Users
            // 
            this.GRPBOX_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRPBOX_Users.Controls.Add(this.LST_Entries);
            this.GRPBOX_Users.Location = new System.Drawing.Point(3, 148);
            this.GRPBOX_Users.Name = "GRPBOX_Users";
            this.GRPBOX_Users.Size = new System.Drawing.Size(653, 193);
            this.GRPBOX_Users.TabIndex = 4;
            this.GRPBOX_Users.TabStop = false;
            this.GRPBOX_Users.Text = "Users";
            // 
            // LST_Entries
            // 
            this.LST_Entries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LST_Entries.FormattingEnabled = true;
            this.LST_Entries.Location = new System.Drawing.Point(6, 14);
            this.LST_Entries.Name = "LST_Entries";
            this.LST_Entries.Size = new System.Drawing.Size(641, 160);
            this.LST_Entries.TabIndex = 0;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Add.Location = new System.Drawing.Point(539, 37);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(118, 23);
            this.BTN_Add.TabIndex = 5;
            this.BTN_Add.Text = "Add";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Edit.Location = new System.Drawing.Point(539, 66);
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(118, 23);
            this.BTN_Edit.TabIndex = 6;
            this.BTN_Edit.Text = "Edit";
            this.BTN_Edit.UseVisualStyleBackColor = true;
            this.BTN_Edit.Click += new System.EventHandler(this.BTN_Edit_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Delete.Location = new System.Drawing.Point(539, 124);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(118, 23);
            this.BTN_Delete.TabIndex = 7;
            this.BTN_Delete.Text = "Delete";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_View
            // 
            this.BTN_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_View.Location = new System.Drawing.Point(539, 95);
            this.BTN_View.Name = "BTN_View";
            this.BTN_View.Size = new System.Drawing.Size(118, 23);
            this.BTN_View.TabIndex = 8;
            this.BTN_View.Text = "View";
            this.BTN_View.UseVisualStyleBackColor = true;
            this.BTN_View.Click += new System.EventHandler(this.BTN_View_Click);
            // 
            // TABCTRL_Controls
            // 
            this.TABCTRL_Controls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABCTRL_Controls.Controls.Add(this.TABPAGE_Welcome);
            this.TABCTRL_Controls.Controls.Add(this.TABPAGE_Login);
            this.TABCTRL_Controls.Location = new System.Drawing.Point(2, 24);
            this.TABCTRL_Controls.Name = "TABCTRL_Controls";
            this.TABCTRL_Controls.SelectedIndex = 0;
            this.TABCTRL_Controls.Size = new System.Drawing.Size(671, 373);
            this.TABCTRL_Controls.TabIndex = 13;
            this.TABCTRL_Controls.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TABCTRL_Controls_Selecting);
            // 
            // TABPAGE_Welcome
            // 
            this.TABPAGE_Welcome.Controls.Add(this.TABCTRL_Main);
            this.TABPAGE_Welcome.Controls.Add(this.BTN_View);
            this.TABPAGE_Welcome.Controls.Add(this.GRPBOX_Users);
            this.TABPAGE_Welcome.Controls.Add(this.BTN_Delete);
            this.TABPAGE_Welcome.Controls.Add(this.BTN_Search);
            this.TABPAGE_Welcome.Controls.Add(this.BTN_Edit);
            this.TABPAGE_Welcome.Controls.Add(this.BTN_Add);
            this.TABPAGE_Welcome.Location = new System.Drawing.Point(4, 22);
            this.TABPAGE_Welcome.Name = "TABPAGE_Welcome";
            this.TABPAGE_Welcome.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_Welcome.Size = new System.Drawing.Size(663, 347);
            this.TABPAGE_Welcome.TabIndex = 1;
            this.TABPAGE_Welcome.Text = "Welcome, ";
            this.TABPAGE_Welcome.UseVisualStyleBackColor = true;
            // 
            // TABCTRL_Main
            // 
            this.TABCTRL_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TABCTRL_Main.Controls.Add(this.TABPAGE_Add);
            this.TABCTRL_Main.Controls.Add(this.TABPAGE_Search);
            this.TABCTRL_Main.Location = new System.Drawing.Point(3, 5);
            this.TABCTRL_Main.Name = "TABCTRL_Main";
            this.TABCTRL_Main.SelectedIndex = 0;
            this.TABCTRL_Main.Size = new System.Drawing.Size(530, 139);
            this.TABCTRL_Main.TabIndex = 12;
            // 
            // TABPAGE_Add
            // 
            this.TABPAGE_Add.Controls.Add(this.RAD_No);
            this.TABPAGE_Add.Controls.Add(this.LBL_ActiveUser);
            this.TABPAGE_Add.Controls.Add(this.RAD_Yes);
            this.TABPAGE_Add.Controls.Add(this.LBL_EnterID);
            this.TABPAGE_Add.Controls.Add(this.TXT_IDInput);
            this.TABPAGE_Add.Controls.Add(this.TXT_NameInput);
            this.TABPAGE_Add.Controls.Add(this.LBL_EnterName);
            this.TABPAGE_Add.Location = new System.Drawing.Point(4, 22);
            this.TABPAGE_Add.Name = "TABPAGE_Add";
            this.TABPAGE_Add.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_Add.Size = new System.Drawing.Size(522, 113);
            this.TABPAGE_Add.TabIndex = 0;
            this.TABPAGE_Add.Text = "Add User";
            this.TABPAGE_Add.UseVisualStyleBackColor = true;
            // 
            // RAD_No
            // 
            this.RAD_No.AutoSize = true;
            this.RAD_No.Location = new System.Drawing.Point(148, 78);
            this.RAD_No.Name = "RAD_No";
            this.RAD_No.Size = new System.Drawing.Size(40, 17);
            this.RAD_No.TabIndex = 20;
            this.RAD_No.TabStop = true;
            this.RAD_No.Text = "No";
            this.RAD_No.UseVisualStyleBackColor = true;
            // 
            // LBL_ActiveUser
            // 
            this.LBL_ActiveUser.AutoSize = true;
            this.LBL_ActiveUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ActiveUser.Location = new System.Drawing.Point(6, 75);
            this.LBL_ActiveUser.Name = "LBL_ActiveUser";
            this.LBL_ActiveUser.Size = new System.Drawing.Size(57, 20);
            this.LBL_ActiveUser.TabIndex = 19;
            this.LBL_ActiveUser.Text = "Active?";
            // 
            // RAD_Yes
            // 
            this.RAD_Yes.AutoSize = true;
            this.RAD_Yes.Location = new System.Drawing.Point(106, 78);
            this.RAD_Yes.Name = "RAD_Yes";
            this.RAD_Yes.Size = new System.Drawing.Size(40, 17);
            this.RAD_Yes.TabIndex = 18;
            this.RAD_Yes.TabStop = true;
            this.RAD_Yes.Text = "Yes";
            this.RAD_Yes.UseVisualStyleBackColor = true;
            // 
            // LBL_EnterID
            // 
            this.LBL_EnterID.AutoSize = true;
            this.LBL_EnterID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EnterID.Location = new System.Drawing.Point(6, 45);
            this.LBL_EnterID.Name = "LBL_EnterID";
            this.LBL_EnterID.Size = new System.Drawing.Size(65, 20);
            this.LBL_EnterID.TabIndex = 16;
            this.LBL_EnterID.Text = "Enter ID:";
            // 
            // TXT_IDInput
            // 
            this.TXT_IDInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_IDInput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.TXT_IDInput.Location = new System.Drawing.Point(106, 44);
            this.TXT_IDInput.Name = "TXT_IDInput";
            this.TXT_IDInput.Size = new System.Drawing.Size(404, 23);
            this.TXT_IDInput.TabIndex = 17;
            // 
            // TXT_NameInput
            // 
            this.TXT_NameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_NameInput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.TXT_NameInput.Location = new System.Drawing.Point(106, 14);
            this.TXT_NameInput.Name = "TXT_NameInput";
            this.TXT_NameInput.Size = new System.Drawing.Size(404, 23);
            this.TXT_NameInput.TabIndex = 15;
            // 
            // LBL_EnterName
            // 
            this.LBL_EnterName.AutoSize = true;
            this.LBL_EnterName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EnterName.Location = new System.Drawing.Point(6, 15);
            this.LBL_EnterName.Name = "LBL_EnterName";
            this.LBL_EnterName.Size = new System.Drawing.Size(94, 20);
            this.LBL_EnterName.TabIndex = 14;
            this.LBL_EnterName.Text = "Enter Name: ";
            // 
            // TABPAGE_Search
            // 
            this.TABPAGE_Search.Controls.Add(this.RAD_ID);
            this.TABPAGE_Search.Controls.Add(this.LBLSearchName);
            this.TABPAGE_Search.Controls.Add(this.LBL_SearchType);
            this.TABPAGE_Search.Controls.Add(this.TXT_SearchInput);
            this.TABPAGE_Search.Controls.Add(this.RAD_Name);
            this.TABPAGE_Search.Location = new System.Drawing.Point(4, 22);
            this.TABPAGE_Search.Name = "TABPAGE_Search";
            this.TABPAGE_Search.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_Search.Size = new System.Drawing.Size(522, 113);
            this.TABPAGE_Search.TabIndex = 1;
            this.TABPAGE_Search.Text = "Search User";
            this.TABPAGE_Search.UseVisualStyleBackColor = true;
            // 
            // RAD_ID
            // 
            this.RAD_ID.AutoSize = true;
            this.RAD_ID.Location = new System.Drawing.Point(175, 62);
            this.RAD_ID.Name = "RAD_ID";
            this.RAD_ID.Size = new System.Drawing.Size(36, 17);
            this.RAD_ID.TabIndex = 16;
            this.RAD_ID.TabStop = true;
            this.RAD_ID.Text = "ID";
            this.RAD_ID.UseVisualStyleBackColor = true;
            // 
            // LBLSearchName
            // 
            this.LBLSearchName.AutoSize = true;
            this.LBLSearchName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSearchName.Location = new System.Drawing.Point(6, 28);
            this.LBLSearchName.Name = "LBLSearchName";
            this.LBLSearchName.Size = new System.Drawing.Size(100, 20);
            this.LBLSearchName.TabIndex = 12;
            this.LBLSearchName.Text = "Search Name:";
            // 
            // LBL_SearchType
            // 
            this.LBL_SearchType.AutoSize = true;
            this.LBL_SearchType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SearchType.Location = new System.Drawing.Point(6, 59);
            this.LBL_SearchType.Name = "LBL_SearchType";
            this.LBL_SearchType.Size = new System.Drawing.Size(91, 20);
            this.LBL_SearchType.TabIndex = 15;
            this.LBL_SearchType.Text = "Search Type:";
            // 
            // TXT_SearchInput
            // 
            this.TXT_SearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_SearchInput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.TXT_SearchInput.Location = new System.Drawing.Point(114, 27);
            this.TXT_SearchInput.Name = "TXT_SearchInput";
            this.TXT_SearchInput.Size = new System.Drawing.Size(391, 23);
            this.TXT_SearchInput.TabIndex = 13;
            // 
            // RAD_Name
            // 
            this.RAD_Name.AutoSize = true;
            this.RAD_Name.Location = new System.Drawing.Point(115, 62);
            this.RAD_Name.Name = "RAD_Name";
            this.RAD_Name.Size = new System.Drawing.Size(54, 17);
            this.RAD_Name.TabIndex = 14;
            this.RAD_Name.TabStop = true;
            this.RAD_Name.Text = "Name";
            this.RAD_Name.UseVisualStyleBackColor = true;
            // 
            // TABPAGE_Login
            // 
            this.TABPAGE_Login.Controls.Add(this.LBL_WelcomeText);
            this.TABPAGE_Login.Controls.Add(this.BTN_Login);
            this.TABPAGE_Login.Controls.Add(this.LBL_EnterPassword);
            this.TABPAGE_Login.Controls.Add(this.TXT_PasswordInput);
            this.TABPAGE_Login.Controls.Add(this.TXT_UsernameInput);
            this.TABPAGE_Login.Controls.Add(this.LBL_EnterUsername);
            this.TABPAGE_Login.Location = new System.Drawing.Point(4, 22);
            this.TABPAGE_Login.Name = "TABPAGE_Login";
            this.TABPAGE_Login.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_Login.Size = new System.Drawing.Size(663, 347);
            this.TABPAGE_Login.TabIndex = 2;
            this.TABPAGE_Login.Text = "Login";
            this.TABPAGE_Login.UseVisualStyleBackColor = true;
            // 
            // LBL_WelcomeText
            // 
            this.LBL_WelcomeText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_WelcomeText.AutoSize = true;
            this.LBL_WelcomeText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WelcomeText.Location = new System.Drawing.Point(86, 99);
            this.LBL_WelcomeText.Name = "LBL_WelcomeText";
            this.LBL_WelcomeText.Size = new System.Drawing.Size(487, 32);
            this.LBL_WelcomeText.TabIndex = 25;
            this.LBL_WelcomeText.Text = "Welcome to the UNCC Student ID Database!";
            // 
            // BTN_Login
            // 
            this.BTN_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Login.Location = new System.Drawing.Point(257, 206);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(151, 32);
            this.BTN_Login.TabIndex = 22;
            this.BTN_Login.Text = "Login";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // LBL_EnterPassword
            // 
            this.LBL_EnterPassword.AutoSize = true;
            this.LBL_EnterPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EnterPassword.Location = new System.Drawing.Point(63, 174);
            this.LBL_EnterPassword.Name = "LBL_EnterPassword";
            this.LBL_EnterPassword.Size = new System.Drawing.Size(111, 20);
            this.LBL_EnterPassword.TabIndex = 20;
            this.LBL_EnterPassword.Text = "Enter Password:";
            // 
            // TXT_PasswordInput
            // 
            this.TXT_PasswordInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_PasswordInput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.TXT_PasswordInput.Location = new System.Drawing.Point(185, 174);
            this.TXT_PasswordInput.Name = "TXT_PasswordInput";
            this.TXT_PasswordInput.PasswordChar = '*';
            this.TXT_PasswordInput.Size = new System.Drawing.Size(404, 23);
            this.TXT_PasswordInput.TabIndex = 21;
            // 
            // TXT_UsernameInput
            // 
            this.TXT_UsernameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_UsernameInput.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.TXT_UsernameInput.Location = new System.Drawing.Point(185, 148);
            this.TXT_UsernameInput.Name = "TXT_UsernameInput";
            this.TXT_UsernameInput.Size = new System.Drawing.Size(404, 23);
            this.TXT_UsernameInput.TabIndex = 19;
            // 
            // LBL_EnterUsername
            // 
            this.LBL_EnterUsername.AutoSize = true;
            this.LBL_EnterUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EnterUsername.Location = new System.Drawing.Point(63, 148);
            this.LBL_EnterUsername.Name = "LBL_EnterUsername";
            this.LBL_EnterUsername.Size = new System.Drawing.Size(116, 20);
            this.LBL_EnterUsername.TabIndex = 18;
            this.LBL_EnterUsername.Text = "Enter Username:";
            // 
            // FRM_UNCCStudentIDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 398);
            this.Controls.Add(this.TABCTRL_Controls);
            this.Controls.Add(this.MNUSTRIP_Bar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MNUSTRIP_Bar;
            this.MinimumSize = new System.Drawing.Size(689, 437);
            this.Name = "FRM_UNCCStudentIDs";
            this.Text = "UNCC Student ID Database";
            this.Load += new System.EventHandler(this.FRM_UNCCStudentIDs_Load);
            this.MNUSTRIP_Bar.ResumeLayout(false);
            this.MNUSTRIP_Bar.PerformLayout();
            this.GRPBOX_Users.ResumeLayout(false);
            this.TABCTRL_Controls.ResumeLayout(false);
            this.TABPAGE_Welcome.ResumeLayout(false);
            this.TABCTRL_Main.ResumeLayout(false);
            this.TABPAGE_Add.ResumeLayout(false);
            this.TABPAGE_Add.PerformLayout();
            this.TABPAGE_Search.ResumeLayout(false);
            this.TABPAGE_Search.PerformLayout();
            this.TABPAGE_Login.ResumeLayout(false);
            this.TABPAGE_Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MNUSTRIP_Bar;
        private System.Windows.Forms.ToolStripMenuItem MNUSTRP_Program;
        private System.Windows.Forms.ToolStripMenuItem MNUSTRP_Restart;
        private System.Windows.Forms.ToolStripMenuItem MNUSTRP_Exit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNUSTRP_About;
        private System.Windows.Forms.Button BTN_Search;
        private System.Windows.Forms.GroupBox GRPBOX_Users;
        private System.Windows.Forms.ListBox LST_Entries;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Edit;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_View;
        private System.Windows.Forms.ToolStripMenuItem MNUSTRP_Export;
        private System.Windows.Forms.TabControl TABCTRL_Controls;
        private System.Windows.Forms.TabPage TABPAGE_Welcome;
        private System.Windows.Forms.TabControl TABCTRL_Main;
        private System.Windows.Forms.TabPage TABPAGE_Add;
        private System.Windows.Forms.RadioButton RAD_No;
        private System.Windows.Forms.Label LBL_ActiveUser;
        private System.Windows.Forms.RadioButton RAD_Yes;
        private System.Windows.Forms.Label LBL_EnterID;
        private System.Windows.Forms.TextBox TXT_IDInput;
        private System.Windows.Forms.TextBox TXT_NameInput;
        private System.Windows.Forms.Label LBL_EnterName;
        private System.Windows.Forms.TabPage TABPAGE_Search;
        private System.Windows.Forms.RadioButton RAD_ID;
        private System.Windows.Forms.Label LBLSearchName;
        private System.Windows.Forms.Label LBL_SearchType;
        private System.Windows.Forms.TextBox TXT_SearchInput;
        private System.Windows.Forms.RadioButton RAD_Name;
        private System.Windows.Forms.TabPage TABPAGE_Login;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label LBL_EnterPassword;
        private System.Windows.Forms.TextBox TXT_PasswordInput;
        private System.Windows.Forms.TextBox TXT_UsernameInput;
        private System.Windows.Forms.Label LBL_EnterUsername;
        private System.Windows.Forms.Label LBL_WelcomeText;
    }
}

