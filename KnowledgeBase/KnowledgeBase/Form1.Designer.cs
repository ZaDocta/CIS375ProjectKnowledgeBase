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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.adminEnterErrorCodeBox = new System.Windows.Forms.TextBox();
            this.adminErrorCodeLabel = new System.Windows.Forms.Label();
            this.adminVersionLabel = new System.Windows.Forms.Label();
            this.adminEnterVersionBox = new System.Windows.Forms.TextBox();
            this.adminEnterDescriptionBox = new System.Windows.Forms.TextBox();
            this.adminDescriptionLabel = new System.Windows.Forms.Label();
            this.adminUnverifiedGridView = new System.Windows.Forms.DataGridView();
            this.adminSearchButton = new System.Windows.Forms.Button();
            this.adminSubmitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.userTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSolvedGridView)).BeginInit();
            this.loginTab.SuspendLayout();
            this.adminTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminUnverifiedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userTab);
            this.tabControl1.Controls.Add(this.loginTab);
            this.tabControl1.Controls.Add(this.adminTab);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.userNarrator.Location = new System.Drawing.Point(3, 139);
            this.userNarrator.Name = "userNarrator";
            this.userNarrator.Size = new System.Drawing.Size(35, 13);
            this.userNarrator.TabIndex = 9;
            this.userNarrator.Text = "label1";
            // 
            // userSubmitButton
            // 
            this.userSubmitButton.Enabled = false;
            this.userSubmitButton.Location = new System.Drawing.Point(640, 235);
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
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(721, 277);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // adminEnterErrorCodeBox
            // 
            this.adminEnterErrorCodeBox.Location = new System.Drawing.Point(100, 15);
            this.adminEnterErrorCodeBox.Name = "adminEnterErrorCodeBox";
            this.adminEnterErrorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.adminEnterErrorCodeBox.TabIndex = 0;
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
            // adminVersionLabel
            // 
            this.adminVersionLabel.AutoSize = true;
            this.adminVersionLabel.Location = new System.Drawing.Point(4, 48);
            this.adminVersionLabel.Name = "adminVersionLabel";
            this.adminVersionLabel.Size = new System.Drawing.Size(90, 13);
            this.adminVersionLabel.TabIndex = 2;
            this.adminVersionLabel.Text = "Software Version:";
            // 
            // adminEnterVersionBox
            // 
            this.adminEnterVersionBox.Location = new System.Drawing.Point(100, 45);
            this.adminEnterVersionBox.Name = "adminEnterVersionBox";
            this.adminEnterVersionBox.Size = new System.Drawing.Size(100, 20);
            this.adminEnterVersionBox.TabIndex = 3;
            // 
            // adminEnterDescriptionBox
            // 
            this.adminEnterDescriptionBox.Location = new System.Drawing.Point(100, 71);
            this.adminEnterDescriptionBox.Name = "adminEnterDescriptionBox";
            this.adminEnterDescriptionBox.Size = new System.Drawing.Size(100, 20);
            this.adminEnterDescriptionBox.TabIndex = 4;
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
            // adminUnverifiedGridView
            // 
            this.adminUnverifiedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminUnverifiedGridView.Location = new System.Drawing.Point(207, 15);
            this.adminUnverifiedGridView.Name = "adminUnverifiedGridView";
            this.adminUnverifiedGridView.Size = new System.Drawing.Size(495, 216);
            this.adminUnverifiedGridView.TabIndex = 6;
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
            // 
            // adminSubmitButton
            // 
            this.adminSubmitButton.Enabled = false;
            this.adminSubmitButton.Location = new System.Drawing.Point(627, 237);
            this.adminSubmitButton.Name = "adminSubmitButton";
            this.adminSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.adminSubmitButton.TabIndex = 8;
            this.adminSubmitButton.Text = "Submit";
            this.adminSubmitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 327);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSolvedGridView)).EndInit();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.adminTab.ResumeLayout(false);
            this.adminTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminUnverifiedGridView)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
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
    }
}

