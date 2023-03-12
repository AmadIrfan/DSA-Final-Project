using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using OutLets.BL;
using OutLets.DL;

namespace OutLets
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            chkShowPassword.Checked = false;
            txtPasswordBox.UseSystemPasswordChar = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            String name = txtNameBox.Text;
            String password = txtPasswordBox.Text;
            String email =txtEmailBox.Text;
            String gId= generateID(); 
            String cnic=txtCnicBox.Text;
            String role =cBoxRole.Text;
            String contact = txtBoxContact.Text;
            String valid = validation(name,email,password,cnic,contact,role);
            if (valid!="") {
                MessageBox.Show(valid,"Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
            Auth auth = new Auth(name,gId,email,password,role,contact,cnic);
            bool ret= AuthDL.addToAuth(auth);
             DialogResult result=MessageBox.Show("saved", "Welcome",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    String body ="Hi "+auth.Name+
                        "!!! \n you have been successfully create account  as a \n \t " + auth.Role + "" +
                        " \n in WholeSale outlets management system at \n \t "
                        + DateTime.Now.ToString();
                            AuthDL.putDataToFile();
  //                  EmailDL.SendMail(auth.Email, body ,"Sign Up");
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

        private void lblLinkLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn= new LogIn();
            logIn.Show();
            this.Hide();
        }
        private String validation(String name,String email,String password,String cnic,String contact,String role)
        {
            foreach (Auth auth in AuthDL.authList) {
                if (auth.Name == name)
                {
                    return "Name Already Exist please select Another Name ";
                }
                else if (auth.Email==email) {
                    return "Email Already Exist please select Another Email ";
                }
            }

            if (password==""|| password.Length < 8)
            {
                  return  "password must be more then 8 character";
            }
            else if (
                !email.Contains("@")|| !email.Contains(".com")) {
                return "Please select correct email ";
            }
            else if (contact.Length<11)
            {
                return "Please select correct Phone Number ";

            }
            else if (cnic.Length<13)
            {
                return "Please select correct CNIC Number ";

            }
            else if (role=="")
            {
                return "Please select your Role  ";

            }
            return "";
        }

        private void txtNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtCnicBox.MaxLength = 13;
            txtBoxContact.MaxLength = 11;
            cBoxRole.Items.Add("manager");
            cBoxRole.Items.Add("rider");
            cBoxRole.Items.Add("employee");


        }
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
       }

        private void txtCnicBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCnicBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("you enterd character", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            }
        }

        private void txtBoxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("you enterd character", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            }
        }
    }

}
