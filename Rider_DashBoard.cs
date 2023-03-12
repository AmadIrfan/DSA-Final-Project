using OutLets.BL;
using OutLets.DL;
using OutLets.Employee;
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
    public partial class Rider_DashBoard : Form
    {
        string id;
        Auth person;
        public Rider_DashBoard(string id)
        {
           this. id = id;
            person = AuthDL.findById(id);
            InitializeComponent();
            lblManagerAccountName.Text = person.Name;
        }

     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Console.WriteLine(this.id + "..2");
            Route route = new Route(this.id);
            route.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine(this.id + "..2");
            Take_Order obj= new Take_Order(this.id);
            obj.Show();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine(this.id + "..2");
            Email obj = new Email(this.id);
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Console.WriteLine(this.id + "..2");
            Add_Shopkeeper obj = new Add_Shopkeeper(this.id);
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ordered_Products obj = new Ordered_Products(this.id);
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Rider_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }
        }

        private void Rider_DashBoard_Load_1(object sender, EventArgs e)
        {

        }
    }
}

