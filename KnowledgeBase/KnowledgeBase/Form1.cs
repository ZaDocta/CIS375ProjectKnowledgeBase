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
            if (string.IsNullOrEmpty(userEnterErrorCodeBox.Text))
            {
                interf.error_code = userEnterErrorCodeBox.Text;
            }
        }
    }
}
