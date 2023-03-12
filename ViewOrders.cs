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
        string id;
        Auth person;
        public ViewOrders(string id)
        {
            InitializeComponent();
            person = AuthDL.findById(id);
            lblManagerAccountName.Text = person.Name;
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
            Console.WriteLine(this.person.Role);
            if (this.person.Role == "manager")
            {

                dashBoard_manager dashBoard = new dashBoard_manager(this.id);
                this.Hide();
                dashBoard.Show();
            }
            else if (this.person.Role == "employee")
            {
                Employee.Employee_Dashboard employee = new Employee.Employee_Dashboard(this.id);
                this.Hide();
                employee.Show();
            }
            else if(this.person.Role == "rider")
            {
                Rider_DashBoard rider = new Rider_DashBoard(this.id);
                this.Hide();
                rider.Show();
            }
        }
        private void productDataBinding()
        {
            OrdersGV.DataSource = null;
            OrdersGV.DataSource = OrderDL.orders;
            OrdersGV.Refresh();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            OrderDL.DataToLists();
            Console.WriteLine(OrderDL.lengthList());
            productDataBinding();
        }
    }
}
