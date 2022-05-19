using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace WindowsFormsApp12
{
    public partial class LoginForm : Form
    {
        SortedDictionary<string, string> indexDictionary = new SortedDictionary<string, string>();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(@"..\..\Data\Index.txt",FileMode.OpenOrCreate,FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string line;
                    string[] parts = new string[2];
                    while ((line = reader.ReadLine()) != null)
                    {
                        parts = line.Split('|');
                        indexDictionary.Add(parts[0], parts[1]);
                    }
                }
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userLoginTextBox.Text;
            string position = null;
            string password = null;



            if (indexDictionary.ContainsKey(userName))
            {
                indexDictionary.TryGetValue(userName, out position);

                using (FileStream fs = new FileStream(@"..\..\Data\Users.txt", FileMode.Open, FileAccess.Read))
                {
                    fs.Position = long.Parse(position);
                    using (StreamReader sr = new StreamReader(fs))
                    {

                        string line = sr.ReadLine();
                        string[] customerInfo = line.Split('|');
                        //string name = customerInfo[1];
                        password = customerInfo[2];
                        //string email = customerInfo[3];
                        //string phone = customerInfo[4];

                    }
                }

            }
            //MessageBox.Show(position);

            if (passLoginTextBox.Text == password)
            {
                Form1 mainForm = new Form1();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid data");
            }


        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
