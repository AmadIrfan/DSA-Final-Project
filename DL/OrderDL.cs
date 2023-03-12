using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutLets.BL;


namespace OutLets.DL
{
    internal class OrderDL
    {
        private static Order head;
     
        public static List<Order> orders = new List<Order>();
        OrderDL()
        {
            head = null;
        }
        public static void addToList(Order temp)
        {
            orders.Add(temp);
        }
        public static void insertTail(Order data)
        {
            if (head == null)
            {
                InsertHead(data);
                return;
            }
            Order ordr = head;
            while (ordr.Next != null)
            {
                ordr = ordr.Next;
            }
            ordr.Next = data;
            data.Previous = ordr;

        }
        public static void printLinkedList()
        {
            Order ordr = head;
            int c = 1;
            while (ordr != null)
            {

                Console.WriteLine(c + ordr.Id + ordr.Products.ProductName);
                c++;
                ordr = ordr.Next;
            }

        }
        public static bool InsertHead(Order data)
        {
            data.Next = head;
            if (head != null)
            {
                head.Previous = data;
            }
            head = data;
            return true;
        }
        public static bool DeleteProduct(Order data)
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
        public static bool addToFile(Order ordr)
        {
            string path = "Order.csv";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(ordr.Id + "," +ordr.Products.Id+","+ ordr.Products.ProductName +","+ordr.Products.Quantity+ "," + ordr.Products.Weight +"," + ordr.Products.Price+","+ordr.Products.Category+","+ordr.ShopKeepers.Id+","+ordr.ShopKeepers.Name+","+ordr.Date+","+ ordr.TotalPrice + "," + ordr.Status);
                file.Flush();
                file.Close();
            }

            return true;
        }

        public static int lengthList()
        {
            int count = 0;
            Order ordr = head;
            while (ordr != null)
            {
                count++;
                ordr = ordr.Next;
            }

            return count;
        }

        public static bool DataToLists()
        {
            Order temp = head;

            orders.Clear();
            while (temp != null)
            {

                addToList(temp);
                temp = temp.Next;
            }

            return true;
        }

        public static bool getFromFile()
        {
            String path = "Order.csv";
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
                            string pro_id = splittedRecord[1];
                            string pro_name = splittedRecord[2];
                            int pro_quantity = int.Parse(splittedRecord[3]);
                            double pro_weight = double.Parse(splittedRecord[4]);
                            double pro_price = double.Parse(splittedRecord[5]);
                            string pro_category = splittedRecord[6];
                            string skeeper_id = splittedRecord[7];
                            string skeeper_name = splittedRecord[8];
                            DateTime date = DateTime.Parse(splittedRecord[9]);
                            double totalPrice = double.Parse(splittedRecord[10]);
                            string status = splittedRecord[11];
                            Product pro = new Product(pro_id, pro_name, pro_category,pro_price,pro_weight,pro_quantity);
                            ShopKeeper sKeeper = new ShopKeeper(skeeper_id, skeeper_name);
                            Order obj = new Order(id,pro,sKeeper,date,totalPrice,status);
                            OrderDL.insertTail(obj);
                        }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "error");
                }
            }
            return false;
        }

        public static Order findByName(String name)
        {
            Order per = head;
            while (per != null)
            {
                if (name == per.ShopKeepers.Name)
                {
                    return per;
                }
                per = per.Next;
            }
            return null;
        }
    }
}
