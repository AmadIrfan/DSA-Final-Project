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

namespace OutLets
{
    public partial class ViewOrders : Form
    {
            String id;
            Auth person;
        public ViewOrders(String id)
        {
            this.id = id;
            person = AuthDL.findById(id);

            InitializeComponent();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Employee.Employee_Dashboard emp = new Employee.Employee_Dashboard(this.id);
            this.Hide();
            emp.Show();

        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            try
            {
            OrderDL.DataToLists();
            DataTable orData= new DataTable();
                orData.Columns.Add("id");
                orData.Columns.Add("Product Name");
                orData.Columns.Add("Category");
                orData.Columns.Add("Shopkeeper Name");
                orData.Columns.Add("OrderDate");
                orData.Columns.Add("Status");
                foreach (Order ord in OrderDL.orders)
            {
            orData.Rows.Add(ord.Id,ord.Products.ProductName, ord.Products.Category, ord.ShopKeepers.Name, ord.Date.ToString(),ord.Status);

            }
            OrdersGV.DataSource=orData;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
