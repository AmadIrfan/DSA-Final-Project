using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
    internal class Rider:Auth
    {

        private String  orderStatus;
        bool isOrderDeliver;
         Rider():base()
        { }
        /*  public Rider(string name, string id, string email, string password, string cnic) : base(name, id, email, password, cnic)
          {

          }
        */
        public string OrderStatus { get => orderStatus; set => orderStatus = value; }
        public bool IsOrderDeliver { get => isOrderDeliver; set => isOrderDeliver = value; }
    }
}
