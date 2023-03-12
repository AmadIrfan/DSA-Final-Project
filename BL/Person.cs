using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
    class Person
    {

        protected String name;
        protected String id;
        protected String email;
        protected String contact;
        protected String cnic;
    
        public Person(String name, String id, String email,String contact,String cnic)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.contact = contact;
            this.cnic = cnic;

        }
        public Person(String email)
        {
            this.email = email;
        }

        public Person() { }
    }
}
