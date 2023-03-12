using OutLets.BL;
using OutLets.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutLets.Employee
{
    public partial class Invoices : Form
    {
        String id;
        Auth person;
        public Invoices(String id)
        {
            person=AuthDL.findById(id);
            this.id = id;

            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                this.Hide();
                logIn.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Employee_Dashboard employee_Dashboard = new Employee_Dashboard(this.id);
            this.Hide();
            employee_Dashboard.Show();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            lblManagerAccountName.Text = person.Name;
            try
            {

                OrderDL.DataToLists();
                DataTable orData = new DataTable();
                orData.Columns.Add("Product Name");
                orData.Columns.Add("OrderDate");
                orData.Columns.Add("Status");

                foreach (Order ord in OrderDL.orders)
                {
                    if (ord.Date == DateTime.Today.Date)
                    {
                        orData.Rows.Add( ord.Products.ProductName, ord.ShopKeepers.Name, ord.Date.ToString(), ord.Status);

                    }

                }
                GVInvoices.DataSource = orData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
