using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OutLets.BL;
using OutLets.DL;

namespace OutLets
{
    public partial class dashBoard_manager : Form
    {
        String id;
        Auth person;
        public dashBoard_manager(String id) 
        {
            this.id = id;
            person=AuthDL.findById(id);
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashBoard_manager_Load(object sender, EventArgs e)
        {
            lblTProductNo.Text =ProductDL.lengthList().ToString();
            lblEmployeeNo.Text =AuthDL.lengthList("rider").ToString();


            ProductDL.lengthList();
            lblManagerAccountName.Text = person.Name.ToString();
        }

        private void btnInventery_Click_1(object sender, EventArgs e)
        {

            View_Inventory vEnv = new View_Inventory(this.id);
            this.Hide();
            vEnv.Show();

        }

        private void btnAnalysis_Click_1(object sender, EventArgs e)
        {
            Report report = new Report(this.id);
            report.Show();
            this.Hide();


        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {

            OutLets.employee emp = new OutLets.employee(this.id);
            emp.Show();
            this.Hide();

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }

        }
    }
}
