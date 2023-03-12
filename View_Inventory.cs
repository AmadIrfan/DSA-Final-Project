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

    public partial class View_Inventory : Form
    {
        String id;
        Auth person;
        public View_Inventory(String id)
        {
            this.id = id;
            InitializeComponent();
            person=AuthDL.findById(id);
            lblManagerAccountName.Text = person.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Product update_Product = new Update_Product(this.id);
            this.Hide();
            update_Product.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteProduct deleteProduct = new DeleteProduct(this.id);
            this.Hide();
            deleteProduct.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product(this.id);
            this.Hide();
            add_Product.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out ????", "Log Out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                LogIn logIn = new LogIn();
                this.Hide();
                logIn.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.person.Role);
            if (this.person.Role == "manager")
            {
           
            dashBoard_manager dashBoard = new dashBoard_manager(this.id);
            this.Hide();
            dashBoard.Show();
            }
        else if (this.person.Role == "employee")
            {
                Employee.Employee_Dashboard employee =new Employee.Employee_Dashboard(this.id);
                this.Hide();
                employee.Show();
            }
        }

        private void View_Inventory_Load(object sender, EventArgs e)
        {
            ProductDL.DataToLists();
            Console.WriteLine(ProductDL.lengthList());
            productDataBinding(); 
            
        }
        private void productDataBinding()
        {
            gridViewProduct.DataSource = null;
            gridViewProduct.DataSource = ProductDL.products;
            gridViewProduct.Refresh();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxName.Text!="")
                {
                gridViewProduct.DataSource = null;
                gridViewProduct.DataSource=ProductDL.proList(txtBoxName.Text);
                gridViewProduct.Refresh();
                }
            else
            {
                productDataBinding();
            }
        }
    }
}
