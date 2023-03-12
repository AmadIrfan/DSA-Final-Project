using OutLets.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutLets.DL
{
    internal class ProductDL
    {
        public static List<Product> products = new List<Product>();


        private static Product head=null;

        public static void addToList(Product temp) {
            products.Add(temp);
        }

        public static void insertTail(Product data)
        {
            if (head == null)
            {
                InsertHead(data);
                return;
            }
            Product pro = head;
            while (pro.Next != null)
            {
                pro = pro.Next;
            }
            pro.Next = data;
            data.Previous = pro;
        }

        public static void printLinkedList()
        {
            Product pro = head;
            int c = 1;
            while (pro!=null) {

                Console.WriteLine(c + pro.Id + pro.ProductName);
                c++;
                pro = pro.Next;
            }

        }
        public static void InsertHead(Product data)
        {
            data.Next = head;
            if (head != null)
            {
                head.Previous = data;
            }
            head = data;
        }

        public static bool DeleteProduct(Product data)
        {
            if (head == null || data == null)
            {
                return false;
            }

            if (data.Next != null)
            {
                data.Next.Previous = data.Previous;
            }
            if (data.Previous != null)
            {
                data.Previous.Next = data.Next;
            }

            if (head == data)
            {
                head = data.Next;
            }
            return true;
        }

        public static bool upDataProduct( Product data)
        {
            Product pro = head;
            while(pro !=null)
            {
                if (pro.Id== data.Id) {
                    
                    pro.Id= data.Id;
                    pro.ProductName= data.ProductName;
                    pro.Category = data.Category;
                    pro.Price = data.Price;
                    pro.Weight = data.Weight;
                    pro.Date=data.Date ;
                }
                pro = pro.Next;
            }
            return true;
        }
        
        public static bool addToFile(Product pro)
        {
            String path = "Product.csv";

            using (StreamWriter file = new StreamWriter(path,true))
            {
                    file.WriteLine(pro.Id + "," + pro.ProductName + "," + pro.Weight + "," + pro.Quantity + "," + pro.Category + "," + pro.Price + ","+pro.Date+",");
                file.Flush();
                file.Close();
            }

                return true;
        }

        public static int lengthList()
        {
            int count = 0;
            Product pro = head;
            while (pro != null){
               count++;
                pro= pro.Next; 
            }

            return count;
        }
        public static bool LinkedListToFile()
        {
            String path = "Product.csv";
            Product pro= head;
            using (StreamWriter file = new StreamWriter(path, false))
            {
                while (pro!=null)
                {

                file.WriteLine(pro.Id + "," + pro.ProductName + "," + pro.Weight + "," + pro.Quantity + "," + pro.Category + "," + pro.Price + "," + pro.Date + ",");
                file.Flush();
                    pro = pro.Next;
                }
                file.Close();
            }
            return true;
        } 

        public static bool DataToLists()
        {
            Product temp = head;

            products.Clear();
            while (temp != null)
            {

                addToList(temp);
                temp = temp.Next;
            }

            return true;
        }

        public static bool getFromFile()
        {
            String path = "Product.csv";
            if (System.IO.File.Exists(path))
            {
                try
                {
                    using (StreamReader file = new StreamReader(path))
                        while (!file.EndOfStream)
                        {
                            string record = file.ReadLine();
                            string[] splittedRecord = record.Split(',');
                            string id = splittedRecord[0];
                            string name = splittedRecord[1];
                            double weight = double.Parse(splittedRecord[2]);
                            int quantity = int.Parse(splittedRecord[3]);
                            string category = splittedRecord[4];
                            double price = double.Parse(splittedRecord[5]);
                            DateTime date = DateTime.Parse(splittedRecord[6]);
                            Product obj = new Product(id,name,category,price,weight,quantity,date);
                           ProductDL.insertTail(obj);
                        }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public static List<Product> proList(String name)
        {
            List<Product> proList = new List<Product>();
            Product pro = head;
            while (pro != null)
            {
                if (name != "" && pro.ProductName.ToLower().Contains(name.ToLower()))
                {
                    proList.Add(pro);
                }
                pro = pro.Next;
            }
                return proList;
        }
    public static Product findByName(String name)
    {
        Product per = head;
        while (per != null)
        {
            if (name == per.ProductName)
            {
                return per;
            }
            per = per.Next;
        }
        return null;
    }

    }
}
