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
            bool HasRegisterd = false;
            using (FileStream fs = new FileStream(@"..\..\Data\Users.txt",FileMode.Append,FileAccess.Write))
            {
                //MessageBox.Show(fs.Position.ToString());
                using (StreamWriter writer = new StreamWriter(@"..\..\Data\Index.txt", true))
                {
                    string indexRecord = usernameTextBox.Text + "|" + fs.Position.ToString(); 
                    writer.WriteLine(indexRecord);
                }
            
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    //int recordSize = usernameTextBox.TextLength + passwordTextBox.TextLength + emailTextBox.TextLength + phoneNumTextBox.TextLength + 4; // 4 delimiters
                    string state = " ";
                    string userInfo = state + "|"
                                    + usernameTextBox.Text + "|"
                                    + passwordTextBox.Text + "|"
                                    + emailTextBox.Text + "|"
                                    + phoneNumTextBox.Text
                        ;
                    writer.WriteLine(userInfo);

                    HasRegisterd = true;

                }
                if (HasRegisterd)
                {
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
