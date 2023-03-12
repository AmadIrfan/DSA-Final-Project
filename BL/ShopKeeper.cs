using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
    internal class ShopKeeper:Person
    {
        private string shopName;
        private string address;
        private string landLine;
        private string area;
        private string city;
        private string country;
        private string zipCode;
        private string province;
        private DateTime date;
        private ShopKeeper next;
        private ShopKeeper previous;
        public ShopKeeper(string id, string name, string email, string contact, string cnic, string shopName, string address, string area, string landLine, string country, string province, string city, string zipCode,DateTime date) : base(id, name, email, contact, cnic)
        {
            this.Id= id;
            this.Name= name;
            this.Contact= contact;
            this.Email= email;
            this.Cnic= cnic; 
            this.Address = address;
            this.ShopName = shopName;
            this.LandLine = landLine;
            this.Area = area;
            this.City = city;
            this.Date=date;
            this.Country= country;
            this.ZipCode= zipCode;
            this.Province= province;
            
        }
        public ShopKeeper(string id, string name)
        {
            this.Id= id;
            this.Name= name;
        }
        public ShopKeeper(string name)
        {
            this.Name= name;
        }
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set =>contact = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Address { get => address; set => address = value; }
        public string ShopName { get => shopName; set => shopName = value; }
        public string LandLine { get => landLine; set => landLine = value; }
        public string Area { get => area; set => area = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string Province { get => province; set => province = value; }
        public DateTime Date { get => date; set => date = value; }
        internal ShopKeeper Next { get => next; set => next = value; }
        internal ShopKeeper Previous { get => previous; set => previous = value; }
        
    }
}
