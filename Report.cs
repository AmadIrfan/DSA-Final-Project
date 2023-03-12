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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace OutLets
{
    public partial class Report : Form
    {
        String id;
        Auth person;
        List<Auth> riders;
        List<Auth> employeess;

        public Report(String id)
        {
           this.id = id;
            InitializeComponent();
            person = AuthDL.findById(id);
            lblManagerAccountName.Text = person.Name;
            ShopKeeperDL.DataToLists();
            ProductDL.DataToLists();
            OrderDL.DataToLists();
            riders = AuthDL.employeeList("rider");
            employeess = AuthDL.employeeList("employee");

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.person.Role=="manager") {
            dashBoard_manager dashBoard= new dashBoard_manager(this.id);
            this.Hide();
            dashBoard.Show();
            }
            else if(this.person.Role=="employee"){
                Employee.Employee_Dashboard emp = new Employee.Employee_Dashboard(this.id);
                this.Hide();
                emp.Show();
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            cBoxReport.Items.Add("Inventory Report");
            cBoxReport.Items.Add("Orders Report");
            cBoxReport.Items.Add("Shop Keepers Report");
            cBoxReport.Items.Add("Employees Report");
            cBoxReport.Items.Add("Riders Report");
        }

        private void cBoxReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cBoxReport.Text == "Inventory Report")
            {
                string path = @"Inventory Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetFontSize(16).SetBold().Add(new Paragraph("WholeSale Outlets"));
                document.SetFontSize(14).Add(new Paragraph("Inventory Report"));
                
                //float col = 100f;
                float[] colWidth = { 100, 200, 50,50,50,100 };
                
                Table table = new Table(colWidth);
                int y = 2;
                
                    Cell cell11 = new Cell(1, 1).SetFontSize(12).SetBold().Add(new Paragraph("Product Id"));
                    Cell cell12 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Name"));
                    Cell cell13 = new Cell(3, 1).SetFontSize(12).SetBold().Add(new Paragraph("Weight"));
                    Cell cell14 = new Cell(4, 1).SetFontSize(12).SetBold().Add(new Paragraph("Quantity"));
                    Cell cell15 = new Cell(5, 1).SetFontSize(12).SetBold().Add(new Paragraph("Price"));
                    Cell cell16 = new Cell(6, 1).SetFontSize(12).SetBold().Add(new Paragraph("Mfg. Date"));
                    table.AddCell(cell11);
                    table.AddCell(cell12);
                    table.AddCell(cell13);
                    table.AddCell(cell14);
                    table.AddCell(cell15);
                    table.AddCell(cell16);

                foreach (Product products in ProductDL.products)
                {
                    Cell cell41 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(products.Id));
                    Cell cell42 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(products.ProductName));
                    Cell cell43 = new Cell(3, y).SetFontSize(12).Add(new Paragraph(products.Weight.ToString()));
                    Cell cell44 = new Cell(4, y).SetFontSize(12).Add(new Paragraph(products.Quantity.ToString()));
                    Cell cell45 = new Cell(5, y).SetFontSize(12).Add(new Paragraph(products.Price.ToString()));
                    Cell cell46 = new Cell(6, y).SetFontSize(12).Add(new Paragraph(products.Date.ToString()));
                    table.AddCell(cell41);
                    table.AddCell(cell42);
                    table.AddCell(cell43);
                    table.AddCell(cell44);
                    table.AddCell(cell45);
                    table.AddCell(cell46);
                    y++;
                }
                MessageBox.Show("Inventory Report generated successfully");
                document.Add(table);
                document.Close();
            }else if (cBoxReport.Text == "Orders Report")
            {
                string path = @"Orders Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetFontSize(16).SetBold().Add(new Paragraph("WholeSale Outlets"));
                document.SetFontSize(14).Add(new Paragraph("Orders Report"));

                float[] colWidth = { 200,250,150 };

                Table table = new Table(colWidth);
                int y = 2;
                Cell cell11 = new Cell(1, 1).SetFontSize(12).SetBold().Add(new Paragraph("OrderId"));
                Cell cell12 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Ordered Products"));
                Cell cell13 = new Cell(3, 1).SetFontSize(12).SetBold().Add(new Paragraph("Status"));
                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell13);

                foreach (Order orderss in OrderDL.orders)
                {
                    Cell cell41 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(orderss.Id));
                    Cell cell42 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(orderss.Products.ToString()));
                    Cell cell43 = new Cell(3, y).SetFontSize(12).Add(new Paragraph(orderss.Status));
                    table.AddCell(cell41);
                    table.AddCell(cell42);
                    table.AddCell(cell43);
                    y++;
                }

                MessageBox.Show("Orders Report generated successfully");
                document.Add(table);
                document.Close();
            }
            else if (cBoxReport.Text == "Shop Keepers Report")
            {
                string path = @"Shop Keepers Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetFontSize(16).SetBold().Add(new Paragraph("WholeSale Outlets"));
                document.SetFontSize(14).Add(new Paragraph("Shop Keepers Report"));

                float[] colWidth = { 150, 150, 100, 50, 50, 100 };

                Table table = new Table(colWidth);
                int y = 2;
                Cell cell11 = new Cell(1, 1).SetFontSize(12).SetBold().Add(new Paragraph("Shop Name"));
                Cell cell12 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Address"));
                Cell cell13 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Area"));
                Cell cell14 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("City"));
                Cell cell15 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Province"));
                Cell cell16 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Landline"));
                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell13);
                table.AddCell(cell14);
                table.AddCell(cell15);
                table.AddCell(cell16);

                foreach (ShopKeeper allShopKeepers in ShopKeeperDL.shopKeepers)
                {
                    Cell cell21 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(allShopKeepers.ShopName));
                    Cell cell22 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(allShopKeepers.Address));
                    Cell cell23 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(allShopKeepers.Area));
                    Cell cell24 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(allShopKeepers.City));
                    Cell cell25 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(allShopKeepers.Province));
                    Cell cell26 = new Cell(2, y).SetFontSize(12).Add(new Paragraph(allShopKeepers.LandLine));
                    table.AddCell(cell21);
                    table.AddCell(cell22);
                    table.AddCell(cell23);
                    table.AddCell(cell24);
                    table.AddCell(cell25);
                    table.AddCell(cell26);
                    y++;
                }

                MessageBox.Show("Shop Keepers Report generated successfully");
                document.Add(table);
                document.Close();
            }
             else if (cBoxReport.Text == "Employees Report")
            {
                string path = @"Employees Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetFontSize(16).SetBold().Add(new Paragraph("WholeSale Outlets"));
                document.SetFontSize(14).Add(new Paragraph("Employees Report"));

                float[] colWidth = { 200, 80, 150, 180 };

                Table table = new Table(colWidth);
                int y = 2;
                Cell cell11 = new Cell(1, 1).SetFontSize(12).SetBold().Add(new Paragraph("ID"));
                Cell cell12 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Name"));
                Cell cell13 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Email"));
                Cell cell14 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Contact"));
                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell13);
                table.AddCell(cell14);

                foreach (Auth employee in employeess)
                {
                    Cell cell21 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(employee.Id));
                    Cell cell22 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(employee.Name));
                    Cell cell23 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(employee.Email));
                    Cell cell24 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(employee.Contact));
                    y++;
                    table.AddCell(cell21);
                    table.AddCell(cell22);
                    table.AddCell(cell23);
                    table.AddCell(cell24);
                }
                MessageBox.Show("Employees Report generated successfully");
                document.Add(table);
                document.Close();
            }
            else if (cBoxReport.Text == "Riders Report")
            {
                string path = @"Riders  Report.pdf";
                PdfWriter writer = new PdfWriter(path);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);
                document.SetFontSize(16).SetBold().Add(new Paragraph("WholeSale Outlets"));
                document.SetFontSize(14).Add(new Paragraph("Riders Report"));

                float[] colWidth = { 200, 80, 150, 180 };

                Table table = new Table(colWidth);
                int y = 2;
                Cell cell11 = new Cell(1, 1).SetFontSize(12).SetBold().Add(new Paragraph("ID"));
                Cell cell12 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Name"));
                Cell cell13 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Email"));
                Cell cell14 = new Cell(2, 1).SetFontSize(12).SetBold().Add(new Paragraph("Contact"));
                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell13);
                table.AddCell(cell14);
                foreach (Auth rider in riders)
                {
                    Cell cell21 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(rider.Id));
                    Cell cell22 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(rider.Name));
                    Cell cell23 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(rider.Email));
                    Cell cell24 = new Cell(1, y).SetFontSize(12).Add(new Paragraph(rider.Contact));
                    y++;
                    table.AddCell(cell21);
                    table.AddCell(cell22);
                    table.AddCell(cell23);
                    table.AddCell(cell24);
                }
                MessageBox.Show("Riders Report generated successfully");
                document.Add(table);
                document.Close();
            }
        }
    }
}
