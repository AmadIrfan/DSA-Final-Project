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
    public partial class changePass : Form
    {
        String Auther;
        Auth data;
        public changePass(String auther)
        {
           this.Auther = auther;
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtBoxPass.Text!="" && txtBoxCPass.Text != "")
            {
                if (txtBoxPass.Text==txtBoxCPass.Text)
                {
                    data=AuthDL.findById(Auther);
                    if (txtBoxPass.Text.Length>=8 && data!=null) {
                        DialogResult reault= MessageBox.Show("Are you sure you want to change password ??","Question",MessageBoxButtons.OK,MessageBoxIcon.Question);
                        if (reault==DialogResult.OK) 
                        { 
                            AuthDL.changePassword(Auther,txtBoxPass.Text.ToString());
                        DialogResult result= MessageBox.Show("Successfully password  changed ", "Alert",MessageBoxButtons.OK,MessageBoxIcon.Question);
                            if (result == DialogResult.OK)
                            {
                                String body = "Hi " +data.Name +"you have been successfuly change password in WholeSale outlets management system at \n " + DateTime.Now.ToString();
                                EmailDL.SendMail(data.Email,body,"Change Password");
                                AuthDL.putDataToFile();
                                LogIn logIn =new LogIn();
                                this.Hide();    
                                logIn.Show();
                            }
                        }
                    }
                }
                else if (txtBoxPass.Text != txtBoxCPass.Text)
                {
                    MessageBox.Show("plase enter same password in fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else

            {
                MessageBox.Show("Field is Empty","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            this.Hide();
            forgetPassword.Show();
        }
    }
}
