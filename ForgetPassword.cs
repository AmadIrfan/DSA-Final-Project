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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void lLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn=new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            String email=txtEmailBox.Text;
            //&& auth.Cnic != cnic
            if (txtEmailBox.Text!="")
            {
                String point = valid(email);
                if(valid(email)=="email is valid")
                {
                    String id = AuthDL.findByMail(email);
                    changePass cPass = new changePass(id);
                    this.Hide();
                    cPass.Show();
                }
                else
                {
                MessageBox.Show(point, "Forget Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                }

            }
            else
            {
                MessageBox.Show("email Box is empty","Forget Password",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);

            }

        }
        private static String valid(String email)
        {
    
            foreach (Auth auth in AuthDL.authList)
            {
                Console.WriteLine(auth.Email+email);
                if (email == auth.Email)
                {
                    return "email is valid";
                }
            }

            return "email is invalid";

        }
    }
}
