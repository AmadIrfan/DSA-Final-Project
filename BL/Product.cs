using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
    internal class Product
    {

        String id;
        String productName;
        int quantity;
        double  weight;
        double price;
        String category;
        Product  next;
        DateTime date;
        Product previous;
        
        public Product(String id,String name,String category, double price ,double weight ,int quantity,DateTime date) { 
         
            this.Id = id;
            this.ProductName = name;
            this.Category = category;
            this.Quantity = quantity;
            this.Price = price;
            this.Weight = weight;
            this.Date = date;
            this.next = null;
            this.previous = null;
        }
        public Product(String id, String name, String category, double price, double weight, int quantity)
        {
            this.Id = id;
            this.ProductName = name;
            this.Category = category;
            this.Quantity = quantity;
            this.Price = price;
            this.Weight = weight;
        }
        public Product(string name,int quantity,double price,string category,double weight)
        {
            this.ProductName = name;
            this.price = price;
            this.Quantity = quantity;
            this.Weight = weight;
            this.Category= category;
        }
        public string Id { get => id; set => id = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Price { get => price; set => price = value; }
        public string Category { get => category; set => category = value; }
        public DateTime Date { get => date; set => date = value; }
        internal Product Next { get => next; set => next = value; }
        internal Product Previous { get => previous; set => previous = value; }
    }
}
