using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OutLets.BL;
using OutLets.DL;
namespace OutLets
{
    public partial class View_Riders : Form
    {
        String id;
        Auth person;

        public View_Riders(String id)
        {
            this.id = id;
            person = AuthDL.findById(id);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dataBind()
        {
            gridViewRiders.DataSource = null;
            gridViewRiders.DataSource = AuthDL.employeeList("rider");
            gridViewRiders.Refresh();   
        }

        private void View_Riders_Load(object sender, EventArgs e)
        {
            dataBind();
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
            Employee.Employee_Dashboard employee = new Employee.Employee_Dashboard(this.id);
            this.Hide();
            employee.Show();
        }
    }
}
