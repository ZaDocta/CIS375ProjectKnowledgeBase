namespace KnowledgeBase
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userTab = new System.Windows.Forms.TabPage();
            this.userSolvedGridView = new System.Windows.Forms.DataGridView();
            this.userNarrator = new System.Windows.Forms.Label();
            this.userSubmitButton = new System.Windows.Forms.Button();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.userDescriptionLabel = new System.Windows.Forms.Label();
            this.userEnterDescriptionBox = new System.Windows.Forms.TextBox();
            this.versionFieldLabel = new System.Windows.Forms.Label();
            this.userEnterVersionBox = new System.Windows.Forms.TextBox();
            this.errorCodeFieldLabel = new System.Windows.Forms.Label();
            this.userEnterErrorCodeBox = new System.Windows.Forms.TextBox();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.employeeNarrator = new System.Windows.Forms.Label();
            this.employeeLogin = new System.Windows.Forms.Button();
            this.passwordFieldLabel = new System.Windows.Forms.Label();
            this.usernameFieldLabel = new System.Windows.Forms.Label();
            this.enterPasswordBox = new System.Windows.Forms.TextBox();
            this.enterUsernameBox = new System.Windows.Forms.TextBox();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.adminDeleteButton = new System.Windows.Forms.Button();
            this.adminNarrator = new System.Windows.Forms.Label();
            this.adminSubmitButton = new System.Windows.Forms.Button();
            this.adminSearchButton = new System.Windows.Forms.Button();
            this.adminUnverifiedGridView = new System.Windows.Forms.DataGridView();
            this.adminDescriptionLabel = new System.Windows.Forms.Label();
            this.adminEnterDescriptionBox = new System.Windows.Forms.TextBox();
            this.adminEnterVersionBox = new System.Windows.Forms.TextBox();
            this.adminVersionLabel = new System.Windows.Forms.Label();
            this.adminErrorCodeLabel = new System.Windows.Forms.Label();
            this.adminEnterErrorCodeBox = new System.Windows.Forms.TextBox();
            this.devTab = new System.Windows.Forms.TabPage();
            this.devDeleteButton = new System.Windows.Forms.Button();
            this.devNarrator = new System.Windows.Forms.Label();
            this.devSubmitButton = new System.Windows.Forms.Button();
            this.devSearchButton = new System.Windows.Forms.Button();
            this.devVerifiedGridView = new System.Windows.Forms.DataGridView();
            this.devEnterSolLabel = new System.Windows.Forms.Label();
            this.devEnterSolutionBox = new System.Windows.Forms.TextBox();
            this.devEnterDescLabel = new System.Windows.Forms.Label();
            this.devEnterSVLabel = new System.Windows.Forms.Label();
            this.devEnterECLabel = new System.Windows.Forms.Label();
            this.devEnterDescriptionBox = new System.Windows.Forms.TextBox();
            this.devEnterVersionBox = new System.Windows.Forms.TextBox();
            this.devEnterErrorCodeBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.userTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSolvedGridView)).BeginInit();
            this.loginTab.SuspendLayout();
            this.adminTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminUnverifiedGridView)).BeginInit();
            this.devTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devVerifiedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userTab);
            this.tabControl1.Controls.Add(this.loginTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Controls.Add(this.devTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.userSolvedGridView);
            this.userTab.Controls.Add(this.userNarrator);
            this.userTab.Controls.Add(this.userSubmitButton);
            this.userTab.Controls.Add(this.userSearchButton);
            this.userTab.Controls.Add(this.userDescriptionLabel);
            this.userTab.Controls.Add(this.userEnterDescriptionBox);
            this.userTab.Controls.Add(this.versionFieldLabel);
            this.userTab.Controls.Add(this.userEnterVersionBox);
            this.userTab.Controls.Add(this.errorCodeFieldLabel);
            this.userTab.Controls.Add(this.userEnterErrorCodeBox);
            this.userTab.Location = new System.Drawing.Point(4, 22);
            this.userTab.Name = "userTab";
            this.userTab.Padding = new System.Windows.Forms.Padding(3);
            this.userTab.Size = new System.Drawing.Size(721, 277);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "User";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // userSolvedGridView
            // 
            this.userSolvedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userSolvedGridView.Location = new System.Drawing.Point(209, 10);
            this.userSolvedGridView.Name = "userSolvedGridView";
            this.userSolvedGridView.ReadOnly = true;
            this.userSolvedGridView.Size = new System.Drawing.Size(506, 219);
            this.userSolvedGridView.TabIndex = 10;
            // 
            // userNarrator
            // 
            this.userNarrator.AutoSize = true;
            this.userNarrator.Location = new System.Drawing.Point(10, 216);
            this.userNarrator.Name = "userNarrator";
            this.userNarrator.Size = new System.Drawing.Size(35, 13);
            this.userNarrator.TabIndex = 9;
            this.userNarrator.Text = "label1";
            // 
            // userSubmitButton
            // 
            this.userSubmitButton.Enabled = false;
            this.userSubmitButton.Location = new System.Drawing.Point(103, 123);
            this.userSubmitButton.Name = "userSubmitButton";
            this.userSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.userSubmitButton.TabIndex = 8;
            this.userSubmitButton.Text = "Submit";
            this.userSubmitButton.UseVisualStyleBackColor = true;
            this.userSubmitButton.Click += new System.EventHandler(this.userSubmitButton_Click);
            // 
            // userSearchButton
            // 
            this.userSearchButton.Location = new System.Drawing.Point(103, 94);
            this.userSearchButton.Name = "userSearchButton";
            this.userSearchButton.Size = new System.Drawing.Size(75, 23);
            this.userSearchButton.TabIndex = 6;
            this.userSearchButton.Text = "Search";
            this.userSearchButton.UseVisualStyleBackColor = true;
            this.userSearchButton.Click += new System.EventHandler(this.userSearchButton_Click);
            // 
            // userDescriptionLabel
            // 
            this.userDescriptionLabel.AutoSize = true;
            this.userDescriptionLabel.Location = new System.Drawing.Point(10, 73);
            this.userDescriptionLabel.Name = "userDescriptionLabel";
            this.userDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.userDescriptionLabel.TabIndex = 5;
            this.userDescriptionLabel.Text = "Description:";
            // 
            // userEnterDescriptionBox
            // 
            this.userEnterDescriptionBox.Location = new System.Drawing.Point(103, 67);
            this.userEnterDescriptionBox.Name = "userEnterDescriptionBox";
            this.userEnterDescriptionBox.Size = new System.Drawing.Size(100, 20);
            this.userEnterDescriptionBox.TabIndex = 4;
            // 
            // versionFieldLabel
            // 
            this.versionFieldLabel.AutoSize = true;
            this.versionFieldLabel.Location = new System.Drawing.Point(7, 43);
            this.versionFieldLabel.Name = "versionFieldLabel";
            this.versionFieldLabel.Size = new System.Drawing.Size(90, 13);
            this.versionFieldLabel.TabIndex = 3;
            this.versionFieldLabel.Text = "Software Version:";
            // 
            // userEnterVersionBox
            // 
            this.userEnterVersionBox.Location = new System.Drawing.Point(103, 40);
            this.userEnterVersionBox.Name = "userEnterVersionBox";
            this.userEnterVersionBox.Size = new System.Drawing.Size(100, 20);
            this.userEnterVersionBox.TabIndex = 2;
            // 
            // errorCodeFieldLabel
            // 
            this.errorCodeFieldLabel.AutoSize = true;
            this.errorCodeFieldLabel.Location = new System.Drawing.Point(7, 13);
            this.errorCodeFieldLabel.Name = "errorCodeFieldLabel";
            this.errorCodeFieldLabel.Size = new System.Drawing.Size(60, 13);
            this.errorCodeFieldLabel.TabIndex = 1;
            this.errorCodeFieldLabel.Text = "Error Code:";
            // 
            // userEnterErrorCodeBox
            // 
            this.userEnterErrorCodeBox.Location = new System.Drawing.Point(103, 10);
            this.userEnterErrorCodeBox.Name = "userEnterErrorCodeBox";
            this.userEnterErrorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.userEnterErrorCodeBox.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.employeeNarrator);
            this.loginTab.Controls.Add(this.employeeLogin);
            this.loginTab.Controls.Add(this.passwordFieldLabel);
            this.loginTab.Controls.Add(this.usernameFieldLabel);
            this.loginTab.Controls.Add(this.enterPasswordBox);
            this.loginTab.Controls.Add(this.enterUsernameBox);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(721, 277);
            this.loginTab.TabIndex = 1;
            this.loginTab.Text = "Employee Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // employeeNarrator
            // 
            this.employeeNarrator.AutoSize = true;
            this.employeeNarrator.Location = new System.Drawing.Point(7, 103);
            this.employeeNarrator.Name = "employeeNarrator";
            this.employeeNarrator.Size = new System.Drawing.Size(35, 13);
            this.employeeNarrator.TabIndex = 5;
            this.employeeNarrator.Text = "label1";
            // 
            // employeeLogin
            // 
            this.employeeLogin.Location = new System.Drawing.Point(72, 67);
            this.employeeLogin.Name = "employeeLogin";
            this.employeeLogin.Size = new System.Drawing.Size(75, 23);
            this.employeeLogin.TabIndex = 4;
            this.employeeLogin.Text = "Login";
            this.employeeLogin.UseVisualStyleBackColor = true;
            this.employeeLogin.Click += new System.EventHandler(this.employeeLogin_Click);
            // 
            // passwordFieldLabel
            // 
            this.passwordFieldLabel.AutoSize = true;
            this.passwordFieldLabel.Location = new System.Drawing.Point(10, 43);
            this.passwordFieldLabel.Name = "passwordFieldLabel";
            this.passwordFieldLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordFieldLabel.TabIndex = 3;
            this.passwordFieldLabel.Text = "Password:";
            // 
            // usernameFieldLabel
            // 
            this.usernameFieldLabel.AutoSize = true;
            this.usernameFieldLabel.Location = new System.Drawing.Point(8, 17);
            this.usernameFieldLabel.Name = "usernameFieldLabel";
            this.usernameFieldLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameFieldLabel.TabIndex = 2;
            this.usernameFieldLabel.Text = "Username:";
            // 
            // enterPasswordBox
            // 
            this.enterPasswordBox.Location = new System.Drawing.Point(72, 40);
            this.enterPasswordBox.Name = "enterPasswordBox";
            this.enterPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.enterPasswordBox.TabIndex = 1;
            // 
            // enterUsernameBox
            // 
            this.enterUsernameBox.Location = new System.Drawing.Point(72, 14);
            this.enterUsernameBox.Name = "enterUsernameBox";
            this.enterUsernameBox.Size = new System.Drawing.Size(100, 20);
            this.enterUsernameBox.TabIndex = 0;
            // 
            // adminTab
            // 
            this.adminTab.Controls.Add(this.adminDeleteButton);
            this.adminTab.Controls.Add(this.adminNarrator);
            this.adminTab.Controls.Add(this.adminSubmitButton);
            this.adminTab.Controls.Add(this.adminSearchButton);
            this.adminTab.Controls.Add(this.adminUnverifiedGridView);
            this.adminTab.Controls.Add(this.adminDescriptionLabel);
            this.adminTab.Controls.Add(this.adminEnterDescriptionBox);
            this.adminTab.Controls.Add(this.adminEnterVersionBox);
            this.adminTab.Controls.Add(this.adminVersionLabel);
            this.adminTab.Controls.Add(this.adminErrorCodeLabel);
            this.adminTab.Controls.Add(this.adminEnterErrorCodeBox);
            this.adminTab.Location = new System.Drawing.Point(4, 22);
            this.adminTab.Name = "adminTab";
            this.adminTab.Size = new System.Drawing.Size(721, 277);
            this.adminTab.TabIndex = 2;
            this.adminTab.Text = "Administrator Verification";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // adminDeleteButton
            // 
            this.adminDeleteButton.Enabled = false;
            this.adminDeleteButton.Location = new System.Drawing.Point(100, 155);
            this.adminDeleteButton.Name = "adminDeleteButton";
            this.adminDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.adminDeleteButton.TabIndex = 10;
            this.adminDeleteButton.Text = "Delete";
            this.adminDeleteButton.UseVisualStyleBackColor = true;
            this.adminDeleteButton.Click += new System.EventHandler(this.adminDeleteButton_Click);
            // 
            // adminNarrator
            // 
            this.adminNarrator.AutoSize = true;
            this.adminNarrator.Location = new System.Drawing.Point(4, 218);
            this.adminNarrator.Name = "adminNarrator";
            this.adminNarrator.Size = new System.Drawing.Size(35, 13);
            this.adminNarrator.TabIndex = 9;
            this.adminNarrator.Text = "label1";
            // 
            // adminSubmitButton
            // 
            this.adminSubmitButton.Enabled = false;
            this.adminSubmitButton.Location = new System.Drawing.Point(100, 126);
            this.adminSubmitButton.Name = "adminSubmitButton";
            this.adminSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.adminSubmitButton.TabIndex = 8;
            this.adminSubmitButton.Text = "Submit";
            this.adminSubmitButton.UseVisualStyleBackColor = true;
            this.adminSubmitButton.Click += new System.EventHandler(this.adminSubmitButton_Click);
            // 
            // adminSearchButton
            // 
            this.adminSearchButton.Enabled = false;
            this.adminSearchButton.Location = new System.Drawing.Point(100, 97);
            this.adminSearchButton.Name = "adminSearchButton";
            this.adminSearchButton.Size = new System.Drawing.Size(75, 23);
            this.adminSearchButton.TabIndex = 7;
            this.adminSearchButton.Text = "Search";
            this.adminSearchButton.UseVisualStyleBackColor = true;
            this.adminSearchButton.Click += new System.EventHandler(this.adminSearchButton_Click);
            // 
            // adminUnverifiedGridView
            // 
            this.adminUnverifiedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminUnverifiedGridView.Location = new System.Drawing.Point(207, 15);
            this.adminUnverifiedGridView.Name = "adminUnverifiedGridView";
            this.adminUnverifiedGridView.Size = new System.Drawing.Size(495, 216);
            this.adminUnverifiedGridView.TabIndex = 6;
            // 
            // adminDescriptionLabel
            // 
            this.adminDescriptionLabel.AutoSize = true;
            this.adminDescriptionLabel.Location = new System.Drawing.Point(31, 74);
            this.adminDescriptionLabel.Name = "adminDescriptionLabel";
            this.adminDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.adminDescriptionLabel.TabIndex = 5;
            this.adminDescriptionLabel.Text = "Description:";
            // 
            // adminEnterDescriptionBox
            // 
            this.adminEnterDescriptionBox.Location = new System.Drawing.Point(100, 71);
            this.adminEnterDescriptionBox.Name = "adminEnterDescriptionBox";
            this.adminEnterDescriptionBox.Size = new System.Drawing.Size(100, 20);
            this.adminEnterDescriptionBox.TabIndex = 4;
            // 
            // adminEnterVersionBox
            // 
            this.adminEnterVersionBox.Location = new System.Drawing.Point(100, 45);
            this.adminEnterVersionBox.Name = "adminEnterVersionBox";
            this.adminEnterVersionBox.Size = new System.Drawing.Size(100, 20);
            this.adminEnterVersionBox.TabIndex = 3;
            // 
            // adminVersionLabel
            // 
            this.adminVersionLabel.AutoSize = true;
            this.adminVersionLabel.Location = new System.Drawing.Point(4, 48);
            this.adminVersionLabel.Name = "adminVersionLabel";
            this.adminVersionLabel.Size = new System.Drawing.Size(90, 13);
            this.adminVersionLabel.TabIndex = 2;
            this.adminVersionLabel.Text = "Software Version:";
            // 
            // adminErrorCodeLabel
            // 
            this.adminErrorCodeLabel.AutoSize = true;
            this.adminErrorCodeLabel.Location = new System.Drawing.Point(34, 18);
            this.adminErrorCodeLabel.Name = "adminErrorCodeLabel";
            this.adminErrorCodeLabel.Size = new System.Drawing.Size(60, 13);
            this.adminErrorCodeLabel.TabIndex = 1;
            this.adminErrorCodeLabel.Text = "Error Code:";
            // 
            // adminEnterErrorCodeBox
            // 
            this.adminEnterErrorCodeBox.Location = new System.Drawing.Point(100, 15);
            this.adminEnterErrorCodeBox.Name = "adminEnterErrorCodeBox";
            this.adminEnterErrorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.adminEnterErrorCodeBox.TabIndex = 0;
            // 
            // devTab
            // 
            this.devTab.Controls.Add(this.devDeleteButton);
            this.devTab.Controls.Add(this.devNarrator);
            this.devTab.Controls.Add(this.devSubmitButton);
            this.devTab.Controls.Add(this.devSearchButton);
            this.devTab.Controls.Add(this.devVerifiedGridView);
            this.devTab.Controls.Add(this.devEnterSolLabel);
            this.devTab.Controls.Add(this.devEnterSolutionBox);
            this.devTab.Controls.Add(this.devEnterDescLabel);
            this.devTab.Controls.Add(this.devEnterSVLabel);
            this.devTab.Controls.Add(this.devEnterECLabel);
            this.devTab.Controls.Add(this.devEnterDescriptionBox);
            this.devTab.Controls.Add(this.devEnterVersionBox);
            this.devTab.Controls.Add(this.devEnterErrorCodeBox);
            this.devTab.Location = new System.Drawing.Point(4, 22);
            this.devTab.Name = "devTab";
            this.devTab.Size = new System.Drawing.Size(721, 277);
            this.devTab.TabIndex = 3;
            this.devTab.Text = "Developer Solution";
            this.devTab.UseVisualStyleBackColor = true;
            // 
            // devDeleteButton
            // 
            this.devDeleteButton.Enabled = false;
            this.devDeleteButton.Location = new System.Drawing.Point(107, 178);
            this.devDeleteButton.Name = "devDeleteButton";
            this.devDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.devDeleteButton.TabIndex = 12;
            this.devDeleteButton.Text = "Delete";
            this.devDeleteButton.UseVisualStyleBackColor = true;
            this.devDeleteButton.Click += new System.EventHandler(this.devDeleteButton_Click);
            // 
            // devNarrator
            // 
            this.devNarrator.AutoSize = true;
            this.devNarrator.Location = new System.Drawing.Point(11, 217);
            this.devNarrator.Name = "devNarrator";
            this.devNarrator.Size = new System.Drawing.Size(35, 13);
            this.devNarrator.TabIndex = 11;
            this.devNarrator.Text = "label1";
            // 
            // devSubmitButton
            // 
            this.devSubmitButton.Enabled = false;
            this.devSubmitButton.Location = new System.Drawing.Point(107, 148);
            this.devSubmitButton.Name = "devSubmitButton";
            this.devSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.devSubmitButton.TabIndex = 10;
            this.devSubmitButton.Text = "Submit";
            this.devSubmitButton.UseVisualStyleBackColor = true;
            this.devSubmitButton.Click += new System.EventHandler(this.devSubmitButton_Click);
            // 
            // devSearchButton
            // 
            this.devSearchButton.Location = new System.Drawing.Point(107, 119);
            this.devSearchButton.Name = "devSearchButton";
            this.devSearchButton.Size = new System.Drawing.Size(75, 23);
            this.devSearchButton.TabIndex = 9;
            this.devSearchButton.Text = "Search";
            this.devSearchButton.UseVisualStyleBackColor = true;
            this.devSearchButton.Click += new System.EventHandler(this.devSearchButton_Click);
            // 
            // devVerifiedGridView
            // 
            this.devVerifiedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devVerifiedGridView.Location = new System.Drawing.Point(214, 12);
            this.devVerifiedGridView.Name = "devVerifiedGridView";
            this.devVerifiedGridView.Size = new System.Drawing.Size(488, 218);
            this.devVerifiedGridView.TabIndex = 8;
            // 
            // devEnterSolLabel
            // 
            this.devEnterSolLabel.AutoSize = true;
            this.devEnterSolLabel.Location = new System.Drawing.Point(53, 99);
            this.devEnterSolLabel.Name = "devEnterSolLabel";
            this.devEnterSolLabel.Size = new System.Drawing.Size(48, 13);
            this.devEnterSolLabel.TabIndex = 7;
            this.devEnterSolLabel.Text = "Solution:";
            // 
            // devEnterSolutionBox
            // 
            this.devEnterSolutionBox.Location = new System.Drawing.Point(107, 92);
            this.devEnterSolutionBox.Name = "devEnterSolutionBox";
            this.devEnterSolutionBox.Size = new System.Drawing.Size(100, 20);
            this.devEnterSolutionBox.TabIndex = 6;
            // 
            // devEnterDescLabel
            // 
            this.devEnterDescLabel.AutoSize = true;
            this.devEnterDescLabel.Location = new System.Drawing.Point(38, 73);
            this.devEnterDescLabel.Name = "devEnterDescLabel";
            this.devEnterDescLabel.Size = new System.Drawing.Size(63, 13);
            this.devEnterDescLabel.TabIndex = 5;
            this.devEnterDescLabel.Text = "Description:";
            // 
            // devEnterSVLabel
            // 
            this.devEnterSVLabel.AutoSize = true;
            this.devEnterSVLabel.Location = new System.Drawing.Point(11, 46);
            this.devEnterSVLabel.Name = "devEnterSVLabel";
            this.devEnterSVLabel.Size = new System.Drawing.Size(90, 13);
            this.devEnterSVLabel.TabIndex = 4;
            this.devEnterSVLabel.Text = "Software Version:";
            // 
            // devEnterECLabel
            // 
            this.devEnterECLabel.AutoSize = true;
            this.devEnterECLabel.Location = new System.Drawing.Point(41, 19);
            this.devEnterECLabel.Name = "devEnterECLabel";
            this.devEnterECLabel.Size = new System.Drawing.Size(60, 13);
            this.devEnterECLabel.TabIndex = 3;
            this.devEnterECLabel.Text = "Error Code:";
            // 
            // devEnterDescriptionBox
            // 
            this.devEnterDescriptionBox.Location = new System.Drawing.Point(107, 66);
            this.devEnterDescriptionBox.Name = "devEnterDescriptionBox";
            this.devEnterDescriptionBox.Size = new System.Drawing.Size(100, 20);
            this.devEnterDescriptionBox.TabIndex = 2;
            // 
            // devEnterVersionBox
            // 
            this.devEnterVersionBox.Location = new System.Drawing.Point(107, 39);
            this.devEnterVersionBox.Name = "devEnterVersionBox";
            this.devEnterVersionBox.Size = new System.Drawing.Size(100, 20);
            this.devEnterVersionBox.TabIndex = 1;
            // 
            // devEnterErrorCodeBox
            // 
            this.devEnterErrorCodeBox.Location = new System.Drawing.Point(107, 12);
            this.devEnterErrorCodeBox.Name = "devEnterErrorCodeBox";
            this.devEnterErrorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.devEnterErrorCodeBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 327);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "KnowledgeBase";
            this.tabControl1.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSolvedGridView)).EndInit();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.adminTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminUnverifiedGridView)).EndInit();
            this.devTab.ResumeLayout(false);
            this.devTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devVerifiedGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Button userSubmitButton;
        private System.Windows.Forms.Button userSearchButton;
        private System.Windows.Forms.Label userDescriptionLabel;
        private System.Windows.Forms.TextBox userEnterDescriptionBox;
        private System.Windows.Forms.Label versionFieldLabel;
        private System.Windows.Forms.TextBox userEnterVersionBox;
        private System.Windows.Forms.Label errorCodeFieldLabel;
        private System.Windows.Forms.TextBox userEnterErrorCodeBox;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage adminTab;
        private System.Windows.Forms.Label userNarrator;
        private System.Windows.Forms.Button employeeLogin;
        private System.Windows.Forms.Label passwordFieldLabel;
        private System.Windows.Forms.Label usernameFieldLabel;
        private System.Windows.Forms.TextBox enterPasswordBox;
        private System.Windows.Forms.TextBox enterUsernameBox;
        private System.Windows.Forms.Label employeeNarrator;
        private System.Windows.Forms.TabPage devTab;
        private System.Windows.Forms.DataGridView userSolvedGridView;
        private System.Windows.Forms.Button adminSubmitButton;
        private System.Windows.Forms.Button adminSearchButton;
        private System.Windows.Forms.DataGridView adminUnverifiedGridView;
        private System.Windows.Forms.Label adminDescriptionLabel;
        private System.Windows.Forms.TextBox adminEnterDescriptionBox;
        private System.Windows.Forms.TextBox adminEnterVersionBox;
        private System.Windows.Forms.Label adminVersionLabel;
        private System.Windows.Forms.Label adminErrorCodeLabel;
        private System.Windows.Forms.TextBox adminEnterErrorCodeBox;
        private System.Windows.Forms.Label adminNarrator;
        private System.Windows.Forms.TextBox devEnterDescriptionBox;
        private System.Windows.Forms.TextBox devEnterVersionBox;
        private System.Windows.Forms.TextBox devEnterErrorCodeBox;
        private System.Windows.Forms.Button devSubmitButton;
        private System.Windows.Forms.Button devSearchButton;
        private System.Windows.Forms.DataGridView devVerifiedGridView;
        private System.Windows.Forms.Label devEnterSolLabel;
        private System.Windows.Forms.TextBox devEnterSolutionBox;
        private System.Windows.Forms.Label devEnterDescLabel;
        private System.Windows.Forms.Label devEnterSVLabel;
        private System.Windows.Forms.Label devEnterECLabel;
        private System.Windows.Forms.Label devNarrator;
        private System.Windows.Forms.Button adminDeleteButton;
        private System.Windows.Forms.Button devDeleteButton;
    }
}

