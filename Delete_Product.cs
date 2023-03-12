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
    public partial class DeleteProduct : Form
    {
        String id;
        Auth person;
        public DeleteProduct(String id)
        {
            this.id = id;
            InitializeComponent();
            person = AuthDL.findById(id);
            lblManagerAccountName.Text = person.Name;
            gridViewProducts.ReadOnly=true;
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            View_Inventory view_Inventory = new View_Inventory(this.id);
            view_Inventory.Show();
            this.Hide();
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

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            
            productDataBind();
        }
         private void productDataBind(){
            gridViewProducts.DataSource = null;
            gridViewProducts.DataSource = ProductDL.products;
            gridViewProducts.Refresh();
          }

        private void gridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewProducts.Columns["btnRowDelete"].Index==e.ColumnIndex)
            {
                DialogResult result = MessageBox.Show("","",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result==DialogResult.OK)
                {
                    int index = gridViewProducts.CurrentCell.RowIndex;
                    Product pro = (Product)gridViewProducts.CurrentRow.DataBoundItem;
                    ProductDL.DeleteProduct(pro);
                    ProductDL.LinkedListToFile();
                    ProductDL.DataToLists();
                    productDataBind();
                }


            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text!="")
            {
                gridViewProducts.DataSource = null;
               gridViewProducts.DataSource =ProductDL.proList(txtName.Text);
                gridViewProducts.Refresh();

            }
            else
            {
                productDataBind();
            }
        }
    }
}
