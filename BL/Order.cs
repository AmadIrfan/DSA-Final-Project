using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
    internal class Order
    {

        private string id;
        private double totalPrice;
        private string status;
        private Product products;
        private ShopKeeper shopKeepers;
        private DateTime date;
        private Order next;
        private Order previous;
        public Order(string id,Product products,ShopKeeper shopKeepers,DateTime date,double totalPrice,String status)
        {
            this.id = id;
            this.products = products;
            this.shopKeepers = shopKeepers;
            this.Date = date;
            this.totalPrice = totalPrice;
            this.status = status;
        }
        public Order(Product pro,ShopKeeper sKeeper)
        {
            this.Products = pro;
            this.shopKeepers = sKeeper;
        }

        public string Id { get => id; set => id = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }
        internal Order Next { get => next; set => next = value; }
        internal Order Previous { get => previous; set => previous = value; }
        internal Product Products { get => products; set => products = value; }
        internal ShopKeeper ShopKeepers { get => shopKeepers; set => shopKeepers = value; }
    }
}
