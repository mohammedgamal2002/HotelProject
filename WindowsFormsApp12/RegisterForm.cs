using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\Data\Users.txt", true))
            {
                int recordSize = usernameTextBox.TextLength + passwordTextBox.TextLength + emailTextBox.TextLength + phoneNumTextBox.TextLength + 4; // 4 delimiters
                string userInfo = recordSize.ToString() + "|"
                                + usernameTextBox.Text + "|"
                                + passwordTextBox.Text + "|"
                                + emailTextBox.Text + "|"
                                + phoneNumTextBox.Text
                    ;
                writer.WriteLine(userInfo);


            }
        }
    }
}
