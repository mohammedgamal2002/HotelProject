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

    public partial class DataForm : Form
    {
        SortedDictionary<string, string> indexDictionary = new SortedDictionary<string, string>();

        List<Customer> customersList = new List<Customer>(); // Customers File Should read into this list

        List<Customer> compactionList = new List<Customer>();
        public DataForm()
        {
            InitializeComponent();

            ReadUsersFile();
            LoadCustomerList();


        }
        private void LoadCustomerList() {
            dataGridView1.Rows.Clear();
            foreach (Customer customer in customersList)
            {
                if (customer.isDeleted == false)
                {
                    dataGridView1.Rows.Add(customer.name, customer.password, customer.email, customer.phoneNum); // puts Customers info in the Grid view

                }
            }
        }
        private void ReadIndexFile() {
            using (StreamReader reader = new StreamReader(@"..\..\Data\Index.txt"))
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
        private void ReadUsersFile()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Data\Users.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] customerInfo = line.Split('|');
                    string state = customerInfo[0];
                    string name = customerInfo[1];
                    string password = customerInfo[2];
                    string email = customerInfo[3];
                    string phone = customerInfo[4];
                    Customer customer = new Customer(name, password, email, phone);
                    customersList.Add(customer);
                    if (state == "*")
                    {
                        customersList[customersList.Count - 1].isDeleted = true;
                    }


                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection deletedRecord = dataGridView1.SelectedRows;
            int index = deletedRecord[0].Index;
            string username = deletedRecord[0].Cells[0].Value.ToString();
            //MessageBox.Show(username);
            string position = null;



            if (indexDictionary.ContainsKey(username))
            {
                indexDictionary.TryGetValue(username, out position);
                using (FileStream fs = new FileStream(@"..\..\Data\Users.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    fs.Position = long.Parse(position);
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write('*');
                    }
                }

            }

        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            ReadIndexFile();
        }
        private void RefreshList() {
            indexDictionary.Clear();
            customersList.Clear();
            dataGridView1.Rows.Clear();
            ReadUsersFile();
            ReadIndexFile();
            LoadCustomerList();
        }
        private void compactButton_Click(object sender, EventArgs e)
        {

            RefreshList();

            File.Delete(@"..\..\Data\Users.txt");
            File.Delete(@"..\..\Data\Index.txt");
            foreach (Customer customer in customersList)
            {
                if (customer.isDeleted == false)
                {
                    using (FileStream fs = new FileStream(@"..\..\Data\Users.txt", FileMode.Append, FileAccess.Write)) {
                        using (StreamWriter writer = new StreamWriter(@"..\..\Data\Index.txt", true))
                        {
                            string indexRecord = customer.name + "|" + fs.Position.ToString();
                            writer.WriteLine(indexRecord);
                        }

                        using (StreamWriter writer = new StreamWriter(fs))
                        {
                            string userInfo = " " + "|"
                                + customer.name + "|"
                                + customer.password + "|"
                                + customer.email + "|"
                                + customer.phoneNum;
                            ;
                            writer.WriteLine(userInfo);

                        }


                    }
                }
            }
        }
    }



    public class Customer
    {
        public string name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNum { get; set; }
        public bool isDeleted { get; set; }
        public Customer(string name, string password, string email, string phoneNum)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.phoneNum = phoneNum;
            this.isDeleted = false;
        }

    }

}
