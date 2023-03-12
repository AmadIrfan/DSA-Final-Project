using System;

using System.Collections.Generic;
using System.Data;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutLets.BL;
namespace OutLets.DL
{
    class AuthDL
    {
        public static List<Auth> authList = new List<Auth>();

        public static bool addToAuth(Auth temp)
        {
            authList.Add(temp);
            return true;
        }

        public static Auth checkUser(Auth auth)
        {
            foreach (Auth user in authList)
            {

                if (auth.Password == user.Password && auth.Email == user.Email)
                {
                    return user;
                }
            }
            return null;
        }
        public static bool changePassword( String id,String password)
        {
            foreach (Auth i in authList)
            {
                if (id == i.Id)
                {
                    i.Password.Replace(i.Password,password);
                    i.Password = password;  
                    return true;
                }
            }
            return false;
        }
        public static bool getDataFromFile()
        {
            String path = "Users.csv";
            if (File.Exists(path))
            {
                try
                {

                    authList.Clear();
                    using (StreamReader file = new StreamReader(path))
                    while (!file.EndOfStream)
                    {
                        String record = file.ReadLine();
                        string[] splittedRecord = record.Split(',');
                        string id = splittedRecord[0];
                        string name = splittedRecord[1];
                        string email = splittedRecord[2];

                        string password = splittedRecord[3];
                        string role = splittedRecord[4];
                        string contact = splittedRecord[5];
                            contact = contact.Replace("phone",null);
                        string cnic = splittedRecord[6];
                            cnic = cnic.Replace("cnic", null); ;
                        Auth auth = new Auth(name, id, email, password, role, contact, cnic);
                        addToAuth(auth);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),"Error" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            return false;
        }
        public static bool putDataToFile()
        {
            String path = "Users.csv";
            using (StreamWriter user = new StreamWriter(path))
            {
                {
                    foreach (Auth a in authList)
                    {
                        var row = string.Format("{0},{1},{2},{3},{4},{5}phone,{6}cnic,", a.Id, a.Name, a.Email, a.Password, a.Role, a.Contact, a.Cnic);
                        user.WriteLine(row);
                    }
                }
                        user.Flush();
            }
            return true;

        }
        public static void printer()
        {
            foreach (Auth auth in AuthDL.authList)
            {
                Console.Write(auth.Id+" |");
                Console.Write(auth.Email + " |");
                Console.Write(auth.Password + " |");
                Console.Write(auth.Cnic + " |");
                Console.Write(auth.Contact + " |");
                Console.Write(auth.Role + " |");
                Console.Write(auth.Name + " |");
                Console.Write(auth.Password + " |");
                Console.Write("\n");
            }
        }
        public static int lengthList(String role)
        {
            int index = 0;
            if (role!="")
            {

                foreach (Auth auth in authList)
                {
                    if (auth.Role == role)
                    {
                        index++;
                    }
                }
            return index;
            }
            else if (role == "")
            {
                foreach(Auth auth in authList)
                {
                        index++;
                }

            return index;
            }

            return index;
        }
        public static String findByMail(String email)
        {
            foreach (Auth auth in authList)
            {
                if (email == auth.Email)
                {
                    return auth.Id;
                }
            }
            return null;
        }
        public static Auth findById(String id)
        {
            foreach (Auth auth in authList)
            {
                if (id == auth.Id)
                {
                    return auth;
                }
            }
            return null;
        }

        public static List<Auth> employeeList( String role)
        {
            List<Auth> employeeList = new List<Auth>();
            foreach (Auth emp in AuthDL.authList)
            {
                if (emp.Role==role )
                {
                    employeeList.Add(emp);
                }
                else if(role=="")
                {
                    if (emp.Role != "manager")
                    {
                    employeeList.Add(emp);

                    }
                }
            }
    
            return employeeList;
        }

        public static bool upDateProduct(Auth auth)
        {
            foreach (Auth i in authList)
            {
                if (auth.Id == i.Id)
                {
                    i.Name= auth.Name;
                    i.Email= auth.Email;
                    i.Cnic= auth.Cnic;
                    i.Contact= auth.Contact;
                    i.Role= auth.Role;
                    i.Id= auth.Id;
                    i.Password= auth.Password;
                }
            }
            return true;
        }
        public static bool deleteProdct(Auth auth)
        {
            authList.Remove(auth);
            return true; 
        }

    }

}