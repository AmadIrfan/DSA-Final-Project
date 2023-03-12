using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
    class emplyee : Auth
    {



        public static List<Rider> rider = new List<Rider>();

        public emplyee(string name, string id, string email, string password, string cnic) : base(name, id, email, password, cnic)
        {

        }
    }
}
