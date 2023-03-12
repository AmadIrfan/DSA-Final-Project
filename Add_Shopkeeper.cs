using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using OutLets.BL;
using OutLets.DL;



namespace OutLets
{
    public partial class Add_Shopkeeper : Form
    {
        String id = "";
        Auth person;
        public Add_Shopkeeper(string id)
        {
            this.id = id;
            person=AuthDL.findById(id);
            InitializeComponent();
            textBox1.Text = person.Name;
            textBox1.ReadOnly = true;
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rider_DashBoard obj = new Rider_DashBoard(this.id);
            obj.Show();
        }

        private void txtbxShopkeeperContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbxShopkeeperContact.MaxLength = 11;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label10.Visible = true;
                errorProvider1.SetError(txtbxShopkeeperContact, "Invalid");
                label10.Text = "Invalid Input";
            }
            else
            {
                label10.Visible = false;
                errorProvider1.SetError(label10, "");
                label10.Text = "";
            }
        }

        private void txtbxShopkeeperName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
                string shopkeeperName = txtbxShopkeeperName.Text;
                string contact = txtbxShopkeeperContact.Text;
                string email = txtbxShopkeeperEmail.Text;
                string cnic = txtbxShopkeeperCNIC.Text;
                string shopName = txtbxShopName.Text;
                string landLine = txtbxShopkeeperLandline.Text;
                string Address = txtbxShopkeeperAddress.Text;
                string area = txtbxShopArea.Text;
                string country = cmboBxCountry.Text;
                string province = cmboBxProvince.Text;
                string city = txtbxCity.Text;
                string zipCode = txtbxZipCode.Text;          
                if (contact.Length < 11)
                {
                MessageBox.Show("Please Complete Contact No!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                if (cnic.Length < 13)
                {
                MessageBox.Show("Please Complete CNIC No!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                if (landLine.Length < 15)
                {
                MessageBox.Show("Please Complete LandLine No!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                if ((shopkeeperName == "" || contact == "" || cnic == "" ||shopName == "" || landLine == "" || Address == "" || area == "" || country == "" || province == "" || city == "" || zipCode == ""))
                {
                    MessageBox.Show("Please Complete Fill Data!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                if (validate_emailaddress.IsMatch(txtbxShopkeeperEmail.Text) != true)
                {
                    MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtbxShopkeeperEmail.Focus();
                    return;
                }
                else
                {
                    string id = generateID();
                    DialogResult result=MessageBox.Show("Are you sure you want to Save ?? ","Save",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DateTime date=DateTime.Now.Date;
                        ShopKeeper obj = new ShopKeeper(id, shopkeeperName, email, contact+"phone", cnic+"cnic", shopName, Address, area, landLine+"lline", country, province, city, zipCode,date);
                        ShopKeeperDL.insertTail(obj);
                        ShopKeeperDL.addToFile(obj);
                        String subject = "Successfully added " + obj.Name + "as Shopkeeper ";
                        MessageBox.Show("Successfully Add_Up.");
                        String body = obj.Name + " have been successfully add as a shopkeeper in outlets management system details are : <br> shopNAme " + obj.ShopName + " <br> Contact " + obj.Contact.Replace("phone", null) + " <br> Cnic " + obj.Cnic.Replace("cnic", null) + " <br> state " + obj.Province + " <br> area " + obj.Area;
                        MessageBox.Show("Successfully Add_Up ");
                        EmailDL.SendMail(obj.Email, body, subject);

                }
            }
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void txtbxShopkeeperCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbxShopkeeperCNIC.MaxLength = 13;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label15.Visible = true;
                errorProvider1.SetError(txtbxShopkeeperCNIC, "Invalid");
                label15.Text = "Invalid Input";

            }
            else
            {
                label15.Visible = false;
                errorProvider1.SetError(label15, "");
                label15.Text = "";

            }
        }

        private void txtbxShopName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label16.Visible = true;
                errorProvider1.SetError(label16, "Invalid");
                label16.Text = "Invalid Input";
            }
            else
            {
                label16.Visible = false;
                errorProvider1.SetError(label16, "");
                label16.Text = "";
            }
        }

        private void txtbxShopkeeperLandline_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtbxShopkeeperLandline.MaxLength = 15;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label17.Visible = true;
                errorProvider1.SetError(txtbxShopkeeperLandline, "Invalid");
                label17.Text = "Invalid Input";
            }
            else
            {
                label17.Visible = false;
                errorProvider1.SetError(label17, "");
                label17.Text = "";
            }
        }
        private void txtbxShopArea_KeyPress(object sender, KeyPressEventArgs e)
        {
         /*   if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label19.Visible = true;
                errorProvider1.SetError(label19, "Invalid");
                label19.Text = "Invalid Input";
            }
            else
            {
                label19.Visible = false;
                errorProvider1.SetError(label19, "");
                label19.Text = "";
            }*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxShopkeeperName.Clear();
            txtbxShopkeeperContact.Clear();
            txtbxShopkeeperEmail.Clear();
            txtbxShopkeeperAddress.Clear();
            txtbxShopArea.Clear();
            txtbxShopkeeperCNIC.Clear();
            txtbxShopkeeperLandline.Clear();
            txtbxShopName.Clear();
            txtbxCity.Clear();
            txtbxZipCode.Clear();
        }

        private void txtbxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label24.Visible = true;
                errorProvider1.SetError(label24, "Invalid");
                label24.Text = "Invalid Input";
            }
            else
            {
                label24.Visible = false;
                errorProvider1.SetError(label24, "");
                label24.Text = "";
            }
        }

        private void txtbxZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                label25.Visible = true;
                errorProvider1.SetError(label25, "Invalid");
                label25.Text = "Invalid Input";
            }
            else
            {
                label25.Visible = false;
                errorProvider1.SetError(label25, "");
                label25.Text = "";
            }
        }

        private void Add_Shopkeeper_Load(object sender, EventArgs e)
        {

        }

        private void Add_Shopkeeper_Load_1(object sender, EventArgs e)
        {

        }
    }
}
