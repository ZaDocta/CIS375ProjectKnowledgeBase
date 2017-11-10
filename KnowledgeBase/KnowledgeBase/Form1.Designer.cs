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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userEnterErrorCodeBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorCodeFieldLabel = new System.Windows.Forms.Label();
            this.userEnterVersionBox = new System.Windows.Forms.TextBox();
            this.versionFieldLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userDescriptionLabel = new System.Windows.Forms.Label();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userSubmitButton = new System.Windows.Forms.Button();
            this.userSubmitLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.userTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.userSubmitLabel);
            this.userTab.Controls.Add(this.userSubmitButton);
            this.userTab.Controls.Add(this.tableLayoutPanel1);
            this.userTab.Controls.Add(this.userSearchButton);
            this.userTab.Controls.Add(this.userDescriptionLabel);
            this.userTab.Controls.Add(this.textBox1);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(669, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userEnterErrorCodeBox
            // 
            this.userEnterErrorCodeBox.Location = new System.Drawing.Point(103, 10);
            this.userEnterErrorCodeBox.Name = "userEnterErrorCodeBox";
            this.userEnterErrorCodeBox.Size = new System.Drawing.Size(100, 20);
            this.userEnterErrorCodeBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(669, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // userEnterVersionBox
            // 
            this.userEnterVersionBox.Location = new System.Drawing.Point(103, 40);
            this.userEnterVersionBox.Name = "userEnterVersionBox";
            this.userEnterVersionBox.Size = new System.Drawing.Size(100, 20);
            this.userEnterVersionBox.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(302, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 223);
            this.tableLayoutPanel1.TabIndex = 7;
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
            // 
            // userSubmitLabel
            // 
            this.userSubmitLabel.AutoSize = true;
            this.userSubmitLabel.Location = new System.Drawing.Point(343, 240);
            this.userSubmitLabel.Name = "userSubmitLabel";
            this.userSubmitLabel.Size = new System.Drawing.Size(291, 13);
            this.userSubmitLabel.TabIndex = 9;
            this.userSubmitLabel.Text = "Didn\'t Find What You\'re Looking For? Submit a New Report:";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.Label userSubmitLabel;
        private System.Windows.Forms.Button userSubmitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button userSearchButton;
        private System.Windows.Forms.Label userDescriptionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label versionFieldLabel;
        private System.Windows.Forms.TextBox userEnterVersionBox;
        private System.Windows.Forms.Label errorCodeFieldLabel;
        private System.Windows.Forms.TextBox userEnterErrorCodeBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

