using OutLets.BL;
using OutLets.DL;
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
    public partial class Ordered_Products : Form
    {
            String id;
            Auth person;
        public Ordered_Products(String id)
        {
            this.id = id;
            person = AuthDL.findById(id);

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rider_DashBoard obj = new Rider_DashBoard(this.id);
            obj.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ordered_Products_Load(object sender, EventArgs e)
        {

            try
            {

                OrderDL.DataToLists();
                DataTable orData = new DataTable();
                orData.Columns.Add("id");
                orData.Columns.Add("Product Name");
                orData.Columns.Add("Category");
                orData.Columns.Add("Shopkeeper Name");
                orData.Columns.Add("OrderDate");
                orData.Columns.Add("Status");
                
                foreach (Order ord in OrderDL.orders)
                {
                    if (ord.Date==DateTime.Today.Date)
                    {
                    orData.Rows.Add(ord.Id, ord.Products.ProductName, ord.Products.Category, ord.ShopKeepers.Name, ord.Date.ToString(), ord.Status);

                    }

                }
                dataGridView.DataSource = orData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
