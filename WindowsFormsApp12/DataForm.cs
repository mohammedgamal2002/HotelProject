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
        List<Customer> customersList = new List<Customer>(); // Customers File Should read into this list
        public DataForm()
        {
            ReadUsersFile();
            InitializeComponent();
            customersList.Add(new Customer("Ahmed", "23 St asdas", "010321030", "22"));             //test case
            customersList.Add(new Customer("mohammed", "23 St asdas", "010321030", "62"));            //test case
            foreach (Customer customer in customersList)
            {
                dataGridView1.Rows.Add(customer.name, customer.address, customer.phoneNum, customer.roomNum); // puts Customers info in the Grid view
            }
        }

        private void ReadUsersFile()
        {
            using (StreamReader reader = new StreamReader(@"..\..\Data\Users.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] customerInfo = line.Split('|');
                    string name = customerInfo[1];
                    string password = customerInfo[2];
                    string email = customerInfo[3];
                    string phone = customerInfo[4];

                    Customer customer = new Customer(name, password, email, phone);
                    customersList.Add(customer);

                }
            }
        }
    }



    public class Customer
    {
        public string name { get; set; }
        public string address { get; set; }
        public string phoneNum { get; set; }
        public string roomNum { get; set; }
        public Customer(string name, string address, string phoneNum, string roomNum)
        {
            this.name = name;
            this.address = address;
            this.phoneNum = phoneNum;
            this.roomNum = roomNum;
        }

    }

}
