using OutLets.BL;
using OutLets.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OutLets
{
    public partial class Take_Order : Form
    {
        String id="";
        String name = "";
        Product produ = null;
        ShopKeeper sKeeper= null;
        double pr = 0;
        Auth person;
        public Take_Order(String id)
        {
            this.id = id;
            this.person =AuthDL.findById(id);
            InitializeComponent();
            ProductDL.DataToLists();
            ShopKeeperDL.DataToLists();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {  
            this.Hide();
            Rider_DashBoard obj= new Rider_DashBoard(this.id);
            obj.Show();
           
            

        }
        private void Take_Order_Load(object sender, EventArgs e)
        {
            textBox1.Text = person.Name;
            textBox1.ReadOnly= true;
            foreach (Product pro in ProductDL.products)
            {
                cBoxProductName.Items.Add(pro.ProductName);
            }

            foreach (ShopKeeper s in ShopKeeperDL.shopKeepers)
            {
                cmbxShopkeeperName.Items.Add(s.Name);     
            }
        }
        private void txtbxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label9.Visible = true;
                errorProvider1.SetError(label9, "Invalid");
                label9.Text = "Invalid Input";
            }
            else
            {
                label9.Visible = false;
                errorProvider1.SetError(label9, "");
                label9.Text = "";
            }
        }

        private void txtbxProductStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label13.Visible = true;
                errorProvider1.SetError(label13, "Invalid");
                label13.Text = "Invalid Input";
            }
            else
            { 
                label13.Visible = false;
                errorProvider1.SetError(label13, "");
                label13.Text = "";
            }
        }

        private void txtbxProductQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label14.Visible = true;
                errorProvider1.SetError(label13, "Invalid");
                label14.Text = "Invalid Input";
            }
            else
            {
                label14.Visible = false;
                errorProvider1.SetError(label13, "");
                label14.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            string name = cmbxShopkeeperName.Text;
            ShopKeeper skeeper = ShopKeeperDL.findByName(name);
          //  string pro_Name = txtbxProductName.Text;
            int quantity = int.Parse(txtbxProductQuantity.Text);

            double price = double.Parse(txtbxProductPrice.Text);
            //string category = cmbxCategory.Text;
            double totalPrice = double.Parse(txtbxProductTotalPrice.Text);
            double weight = double.Parse(txtbxProductWeight.Text);
       //     Product pro = new Product(name, quantity, price, category, weight);
            if (quantity == 0||price==0)
            {
                MessageBox.Show("Please Complete Fill Data!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string id = generateID();
                DialogResult result = MessageBox.Show("Are you sure you want to Save ?? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                        try
                        {

                        OrderDL.DataToLists();
                        Order obj = new Order(id,produ,skeeper,DateTime.Now.Date,totalPrice,"panding");
                        OrderDL.insertTail(obj);
                        OrderDL.addToFile(obj);
                        MessageBox.Show("Successfully Add_Up.");
                            String subject = "Successfully Order places";
                        MessageBox.Show("Successfully Add_Up.");
                            String body = sKeeper.Name + " Your Order have been successfully placed: <bs> details are : <br> Product name " + obj.Products.ProductName + " <br> Quantity " + obj.Products.Quantity + " <br> Total Price " +obj.TotalPrice + " <br> Date " + obj.Date + " <br> Status " + obj.Status;
                            MessageBox.Show("Successfully Add_Up ");
                            EmailDL.SendMail(sKeeper.Email, body, subject);
                        }
                        catch (Exception exe) {
                        MessageBox.Show(exe.Message.ToString(),"Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Stop);
                        
                        }

                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void txtbxProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label10.Visible = true;
                errorProvider1.SetError(label10, "Invalid");
                label10.Text = "Invalid Input";
            }
            else
            {
                label10.Visible = false;
                errorProvider1.SetError(label10, "");
                label10.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtbxProductPrice.Clear();
            txtbxProductQuantity.Clear();
            txtbxProductTotalPrice.Clear();
            txtbxProductWeight.Clear();
        }

        private void cBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProductName.Text!="") {
            String proName= cBoxProductName.Text;
            produ=ProductDL.findByName(proName);
                textBox2.Text = produ.Category;
                txtbxProductWeight.Text = produ.Weight.ToString();
                if (produ.Quantity>1)
                {
                pr  = produ.Price / produ.Quantity;
                txtbxProductPrice.Text=pr.ToString();
                }
            }

        }

        private void txtbxProductQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtbxProductQuantity.Text=="") {
                txtbxProductQuantity.Text = 0.ToString();
            }
           String tPQ= txtbxProductQuantity.Text;
                  
            double tPr=int.Parse(tPQ) * pr;
            txtbxProductTotalPrice.Text = tPr.ToString();
        }

        private void cBoxProductName_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void cBoxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cBoxProductName_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress= true;
        }

        private void cmbxShopkeeperName_SelectedIndexChanged(object sender, EventArgs e)
        {
            sKeeper = ShopKeeperDL.findByName(cmbxShopkeeperName.Text);
        }
    }
}
