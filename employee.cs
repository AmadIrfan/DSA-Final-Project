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
    public partial class employee : Form
    {
        string id;
        Auth person;
        String role = "";
        String name ="";
        public employee(String id)
        {
            this.id = id;
            InitializeComponent();
            person = AuthDL.findById(id);
            lblManagerAccountName.Text = person.Name;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            dashBoard_manager dash=new dashBoard_manager(this.id);
            this.Hide();
            dash.Show();
        }

        private void lblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
        }

        private void employee_Load(object sender, EventArgs e)
        {
            cBoxRole.Items.Add("rider");
            cBoxRole.Items.Add("employee");
            dataBinding();
        }

        private void cBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxRole_TextChanged(object sender, EventArgs e)
        {
            this.role = cBoxRole.Text;
            dataBinding();
        }

        private void cBoxRole_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void gridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             DialogResult result=  MessageBox.Show("Are you sour you want to Edit/ employee ? ", "Questions", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    if (gridViewEmployee.Columns["Edit"].Index==e.ColumnIndex)
                    {
                        int index = gridViewEmployee.CurrentCell.RowIndex;
                        Auth per = (Auth)gridViewEmployee.CurrentRow.DataBoundItem;
                        dataBinding();
                        
                        AuthDL.upDateProduct(per);
                        DialogResult rer = MessageBox.Show("User Update successfully ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (rer==  DialogResult.OK) {
                        
                        }
                
                    }
                    else if (gridViewEmployee.Columns["Delete"].Index==e.ColumnIndex)
                    {
                        int index = gridViewEmployee.CurrentCell.RowIndex;
                        Auth per = (Auth)gridViewEmployee.CurrentRow.DataBoundItem;
                        AuthDL.deleteProdct(per);
                        dataBinding();
                        DialogResult rer =MessageBox.Show("User Deletes successfully ", "Alert", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                        if (rer == DialogResult.OK)
                        {

                        }


                    }
                    AuthDL.putDataToFile();
            
                }
        }
        private void dataBinding()
        {
            gridViewEmployee.DataSource = null;


            gridViewEmployee.DataSource = AuthDL.employeeList(this.role);


            gridViewEmployee.Refresh();
        }


    }
}
