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
    public partial class Email : Form
    {
            String id;
            Auth person;
        public Email(String id)
        {
            this.id = id;
            person = AuthDL.findById(id);

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Rider_DashBoard obj = new Rider_DashBoard(this.id);
            this.Hide();
            obj.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

            String mail = textBox7.Text;
            String subject = richTextBox1.Text;
            String body = richTextBox2.Text;
            DialogResult result=    MessageBox.Show("Are you sure you want to send email. ","Send Email ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    EmailDL.SendMail(mail, subject, body);
                 MessageBox.Show("Sent ","Send Email ",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else
                {
                 MessageBox.Show("Canceled ","Send Email ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OKCancel,MessageBoxIcon.None);
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
           textBox7.Clear();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void Email_Load(object sender, EventArgs e)
        {
            textBox1.Text =person.Name;
            textBox1.ReadOnly= true;
        }
    }
}
