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
    public partial class Update_Product : Form
    {
        String id;
        Auth person;
        public Update_Product(String id)
        {
            this.id = id;
            InitializeComponent();
            person=AuthDL.findById(id);
            lblManagerAccountName.Text=person.Name;
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            View_Inventory view_Inventory=new View_Inventory(this.id);
            view_Inventory.Show();
            this.Hide();
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

        }

        private void Update_Product_Load(object sender, EventArgs e)
        {
            productDataBind();
        }
        private void productDataBind()
        {
            gridViewProducts.DataSource = null;
            gridViewProducts.DataSource = ProductDL.products;
            gridViewProducts.Refresh();
        }

        private void gridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewProducts.Columns["BtnUpdate"].Index == e.ColumnIndex)
            {
                DialogResult result = MessageBox.Show("Are you Sour you want to Update Product ?","Questions",MessageBoxButtons.OKCancel,MessageBoxIcon.None);
                if(result == DialogResult.OK) { 
                int index = gridViewProducts.CurrentCell.RowIndex;
                Product pro = (Product)gridViewProducts.CurrentRow.DataBoundItem;
                ProductDL.upDataProduct(pro);
                ProductDL.DataToLists();
                ProductDL.LinkedListToFile();
                productDataBind();
                }
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != null)
            {
                gridViewProducts.DataSource = null;
                gridViewProducts.DataSource = ProductDL.proList(textBoxName.Text);
                gridViewProducts.Refresh();
            }
            else
            {
                productDataBind();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
