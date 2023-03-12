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
    public partial class ViewShopKeepers : Form
    {
            String id;
            Auth person;
        public ViewShopKeepers(String id)
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

        private void ViewShopKeepers_Load(object sender, EventArgs e)
        {
            lbl.Text = ShopKeeperDL.lengthList().ToString();
           ShopKeepersGV.ReadOnly= true;
            lblManagerAccountName.Text = person.Name;
            dataBind(); 
        }

        private void dataBind() {
            ShopKeepersGV.DataSource = null;
            ShopKeepersGV.DataSource = ShopKeeperDL.shopKeepers;
            ShopKeepersGV.Refresh();
        }
    }
}
