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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            lbllbl.Hide();
            chkShowPassword.Checked= false;
            txtPasswordBox.UseSystemPasswordChar = true;
         }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            Auth auther = null;
            String email = txtEmailBox.Text;
            String password = txtPasswordBox.Text;
            Auth auth = new Auth(email, password);
            auther = AuthDL.checkUser(auth);
            if (auther == null)
            {
                  DialogResult res = MessageBox.Show("Please enter Valid Credential", "Log In", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
            else
            {
                if (email != "" && password != "")
                {
                    try
                    {
                        if (auther != null)
                        {
                            String body = "you login as a \n " + auther.Role + " \n in WholeSale outlets management system at \n " + DateTime.Now.ToString();
                 //           EmailDL.SendMailAtLoginTime(auther.Email, body,"log In");

                            if (auther.Role == "manager")
                            {
                                dashBoard_manager dashBoard = new dashBoard_manager(auther.Id);
                                this.Hide();
                                dashBoard.Show();
                         
                            }
                            else if (auther.Role == "employee")
                            {
                                Employee.Employee_Dashboard employee = new Employee.Employee_Dashboard(auther.Id);
                                this.Hide();
                                employee.Show();
                            }
                            else if (auther.Role == "rider")
                            {
                                Rider_DashBoard rider_DashBoard = new Rider_DashBoard(auther.Id);
                                this.Hide();
                                rider_DashBoard.Show();
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Please enter Valid Credentials ", "Log In", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                if (result == DialogResult.OK)
                                {
                                    txtEmailBox.Clear();
                                    txtPasswordBox.Clear();
                                }
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Not Founded ", "Log In", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                            if (result == DialogResult.OK)
                            {
                                txtEmailBox.Clear();
                                txtPasswordBox.Clear();
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Fild is Empty ","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
                }
            }
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
            {

            if (chkShowPassword.Checked == true)
            {
                txtPasswordBox.UseSystemPasswordChar = false;
            }
            else
                {
                txtPasswordBox.UseSystemPasswordChar = true;
                }
        }
     
        private void lblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword=new ForgetPassword();
            this.Hide();
            forgetPassword.Show();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
    
}