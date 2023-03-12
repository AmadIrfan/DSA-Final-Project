using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using OutLets.BL;

namespace OutLets.DL
{
    internal class ShopKeeperDL
    {
        private static ShopKeeper head;

        public static List<ShopKeeper> shopKeepers = new List<ShopKeeper>();
        ShopKeeperDL()
        {
            head = null;
        }
        public static void addToList(ShopKeeper temp)
        {
            shopKeepers.Add(temp);
        }
        public static void insertTail(ShopKeeper data)
        {
            if (head == null)
            {
                InsertHead(data);
                return;
            }
            ShopKeeper Shopkpr = head;
            while (Shopkpr.Next != null)
            {
                Shopkpr = Shopkpr.Next;
            }
            Shopkpr.Next = data;
            data.Previous = Shopkpr;

        }

        public static void printLinkedList()
        {
            ShopKeeper Shopkpr = head;
            int c = 0;
            while (Shopkpr != null)
            {
                Console.WriteLine(Shopkpr.Id + "," + Shopkpr.Name + "," + Shopkpr.Email + "," + Shopkpr.Contact + "," + Shopkpr.Cnic + "," + Shopkpr.ShopName + "," + Shopkpr.Address + "," + Shopkpr.Area + "," + Shopkpr.LandLine + "," + Shopkpr.Country + "," + Shopkpr.Province + "," + Shopkpr.City + "," + Shopkpr.ZipCode + "," + Shopkpr.Date);
                c++;
                Shopkpr = Shopkpr.Next;
            }
            Console.WriteLine(c);

        }
                                               
        public static bool InsertHead(ShopKeeper data)
        {
            data.Next = head;
            if (head != null)
            {
                head.Previous = data;
            }
            head = data;
            return true;
        }

        public static bool DeleteProduct(ShopKeeper data)
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
        public static bool addToFile(ShopKeeper Shopkpr)
        {
            string path = "Shopkeeper.csv";
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(Shopkpr.Id + "," + Shopkpr.Name + "," + Shopkpr.Email + "," + Shopkpr.Contact + "," + Shopkpr.Cnic+ "," + Shopkpr.ShopName+ "," + Shopkpr.Address + ","+Shopkpr.Area+","+Shopkpr.LandLine+","+ Shopkpr.Country + "," +Shopkpr.Province + "," + Shopkpr.City + "," + Shopkpr.ZipCode+","+Shopkpr.Date);
                file.Flush();
                file.Close();
            }

            return true;
        }

        public static int lengthList()
        {
            int count = 0;
            ShopKeeper Shopkpr = head;
            while (Shopkpr != null)
            {
                count++;
                Shopkpr = Shopkpr.Next;
            }

            return count;
        }

        public static bool DataToLists()
        {
            ShopKeeper temp = head;

            shopKeepers.Clear();
            while (temp != null)
            {

                addToList(temp);
                temp = temp.Next;
            }

            return true;
        }

        public static bool getFromFile()
        {
            String path = "Shopkeeper.csv";
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
                            string email = splittedRecord[2];
                            string contact = splittedRecord[3];
                            contact = contact.Replace("phone",null);
                            string cnic = splittedRecord[4];
                            cnic = cnic.Replace("cnic",null);
                            string shopName = splittedRecord[5];
                            string address = splittedRecord[6];
                            string area = splittedRecord[7];
                            string landLine = splittedRecord[8];
                            landLine = landLine.Replace("lline",null);
                            string country = splittedRecord[9];
                            string province = splittedRecord[10];
                            string city = splittedRecord[11];
                            string zipCode = splittedRecord[12];
                            DateTime date =DateTime.Parse(splittedRecord[13]);
                            ShopKeeper obj = new ShopKeeper(id, name, email, contact, cnic, shopName, address, area, landLine, country,province, city, zipCode,date);                         
                            ShopKeeperDL.insertTail(obj);
                        
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

        public static ShopKeeper findByName(String name)
        {
            ShopKeeper per = head;
            while (per != null)
            {
                if (name == per.Name)
                {
                    return per;
                }
                per = per.Next;
            }
            return null;
        }
    }
}
