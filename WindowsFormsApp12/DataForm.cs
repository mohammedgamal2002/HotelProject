using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            InitializeComponent();
            customersList.Add(new Customer("Ahmed", "23 St asdas", "010321030", "22"));             //test case
            customersList.Add(new Customer("mohammed", "23 St asdas", "010321030", "62"));            //test case

            foreach (Customer customer in customersList)
            {
                dataGridView1.Rows.Add(customer.name,customer.address , customer.phoneNum , customer.roomNum); // puts Customers info in the Grid view
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
