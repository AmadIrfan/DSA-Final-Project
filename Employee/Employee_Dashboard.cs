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
    public partial class Employee_Dashboard : Form
    {
        String id;
        Auth person;
        public Employee_Dashboard(String id)
        {
            this.id = id;
            person=AuthDL.findById(id);
            InitializeComponent();
        
        }

        private void Employee_Dashboard_Load(object sender, EventArgs e)
        {
            lblManagerAccountName.Text = person.Name;
            ShopKeeperDL.DataToLists();
            lblShopKeepersCount.Text = ShopKeeperDL.lengthList().ToString();
            lblRidersCount.Text = AuthDL.lengthList("rider").ToString();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrders=new ViewOrders(this.id);
            this.Hide();
            viewOrders.Show();
        }

        private void btnShopKeeper_Click(object sender, EventArgs e)
        {
            ViewShopKeepers viewShop=new ViewShopKeepers(this.id);
            this.Hide();
            viewShop.Show();
        }

        private void btnRider_Click(object sender, EventArgs e)
        {
            View_Riders riders=new View_Riders(this.id);
            this.Hide();
            riders.Show();

        }

        private void btnInventory_Click(object sender, EventArgs e)

        {


            View_Inventory view = new View_Inventory(this.id);
            this.Hide();
            view.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report(this.id);
            this.Hide();
            report.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
        }
       
        private void btnSalesManagement_Click(object sender, EventArgs e)
        {
            SalesManagement sm = new SalesManagement(this.id);
            this.Hide();
            sm.Show();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Employee.Invoices invoices = new Employee.Invoices(this.id);
            this.Hide();
            invoices.Show();
        }
    }
}
