using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutLets.DL;
using OutLets.BL;
using System.Management.Instrumentation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OutLets.Employee
{
    public partial class Route : Form
    {
        String id;
        Auth person;
        public Route(String id)
        {
            this.id = id;
            person=AuthDL.findById(id);
            Console.WriteLine(person.Name);
            InitializeComponent();
            ShopKeeperDL.DataToLists();
            AuthDL.printer();
            Console.WriteLine(ShopKeeperDL.shopKeepers.Count);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cBoxAllShopKeeper_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cBoxAllShopKeeper_TextChanged(object sender, EventArgs e)
        {
            string name = cBoxAllShopKeeper.Text;
            string address = "";
            string area = "";
            string city = "";
            string country = "";
            String prov = "";

            foreach (ShopKeeper spLocation in ShopKeeperDL.shopKeepers)
            {
                if(name == spLocation.Name)
                {
                Console.WriteLine(spLocation.Name+ spLocation.Area+spLocation.City+ spLocation.Province + spLocation.Country);
                    address = spLocation.Address;
                    area = spLocation.Area;
                    city = spLocation.City;
                    prov = spLocation.Province;
                    country = spLocation.Country;
                    Console.WriteLine(area+city+prov+country);
                    break;
                }
            }
            try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://maps.google.com/maps?q=");
            if(name != String.Empty)
                {
                  //  queryAddress.Append(address + "," + "+");
                    queryAddress.Append(area + "," + "+");
                    queryAddress.Append(city + "," + "+");
                    queryAddress.Append(country + ","+"+");
                }
                webBrowserMap.Navigate(queryAddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void Route_Load(object sender, EventArgs e)
        {
            lblManagerAccountName.Text = this.person.Name;
            foreach (ShopKeeper spLocation in ShopKeeperDL.shopKeepers)
            {

                cBoxAllShopKeeper.Items.Add(spLocation.Name);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Rider_DashBoard rider = new Rider_DashBoard(this.id);
            this.Hide();
            rider.Show();
        }
    }
}
