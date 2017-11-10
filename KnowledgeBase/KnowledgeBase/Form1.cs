using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeBase
{
    public partial class Form1 : Form
    {
        private Interface interf;
        public Form1()
        {
            InitializeComponent();
            interf = new Interface();
        }

        private void userSearchButton_Click(object sender, EventArgs e)
        {
            userNarrator.Text = "";
            if (!string.IsNullOrEmpty(userEnterErrorCodeBox.Text))//if the user entered something in the Error Code field
            {
                interf.error_code = userEnterErrorCodeBox.Text;
            }
            else
            {
                userNarrator.Text += Environment.NewLine + "Please Enter an Error Code.";
            }
            if(!string.IsNullOrEmpty(userEnterVersionBox.Text))//if the user entered something in the Version field
            {
                interf.version = userEnterVersionBox.Text;
            }
            else
            {
                userNarrator.Text += Environment.NewLine + "Please Enter a Software Version.";
            }
            if (!string.IsNullOrEmpty(userEnterDescriptionBox.Text))//if the yadda yadda you know
            {
                interf.description = userEnterDescriptionBox.Text;
            }
            else
            {
                userNarrator.Text += Environment.NewLine + "Please Enter a Description.";
            }
            userSubmitButton.Enabled = true;
        }

        private void employeeLogin_Click(object sender, EventArgs e)
        {
            employeeNarrator.Text = "";
            if (!string.IsNullOrEmpty(enterUsernameBox.Text))
            {
                if (!string.IsNullOrEmpty(enterPasswordBox.Text))
                {
                    //user.username = enterUsernameBox.Text;
                    //user.password = enterPasswordBox.Text;

                }
                else
                {
                    employeeNarrator.Text += Environment.NewLine + "Enter a Password, genius.";
                }
            }
            else
            {
                employeeNarrator.Text += Environment.NewLine + "Enter a Username, smart guy.";
            }
            
            
            
        }
    }
}
