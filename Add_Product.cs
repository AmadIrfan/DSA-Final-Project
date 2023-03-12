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
    public partial class Add_Product : Form
    {
        String id;
        Auth person;
        public Add_Product(String id)
        {
            this.id = id;
            InitializeComponent();
            person = AuthDL.findById(id);
            lblManagerAccountName.Text = person.Name;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            View_Inventory inv = new View_Inventory(this.id);
            this.Hide();
            inv.Show();

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCat.Text!="" && txtName.Text != "" && txtPrice.Text != "" && txtQty.Text != "" && txtWeight .Text != "")
                {
                   
                String id =generateID();
       
                String name=txtName.Text;
                String category= txtCat.Text;
                int quantity =int.Parse(txtQty.Text);
                double weight=double.Parse(txtWeight.Text);
                double price=double.Parse(txtPrice.Text);
      
                      DialogResult result=MessageBox.Show("Are you sure you want to Save ?? ","Save",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        Product TempPro = new Product(id,name,category, price,weight,quantity,DateTime.Now.Date);
                        ProductDL.addToList(TempPro);
                        ProductDL.insertTail(TempPro);
                        ProductDL.addToFile(TempPro);
                        txtWeight.Clear();
                        txtName.Clear(); 
                        txtPrice.Clear();
                        txtQty.Clear();
                        txtWeight.Clear();
                    }
                    else
                    {
                        DialogResult res=MessageBox.Show("Are you sure you want to Save ?? ","Save",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    }  

                }
                else
                {
                    MessageBox.Show("same Field's are empty ", "Empty Field",MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),ex.GetType().ToString(),MessageBoxButtons.OKCancel,MessageBoxIcon.Hand);
            }
        }
            public string generateID()
            {
                return Guid.NewGuid().ToString("N");
            }

        private void Add_Product_Load(object sender, EventArgs e)
        {
        }
    }
}
