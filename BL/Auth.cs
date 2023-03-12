using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutLets.BL
{
     class Auth:Person
    {
        String password;
        String role;

      
        public Auth(String name, String id, String email, String password,String role,String contact,String cnic): base(name,id,email,contact,cnic)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Password= password;
            this.role= role;
            this.Contact = contact;
            this.Cnic = cnic;
        }

      /*  public Auth(String name, String password ):base(name)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Password = password;
            this.role = role;
            this.Contact = contact;
            this.Cnic = cnic;
        }
*/
        public Auth(String email, String password) : base(email)
        {
            this.Password= password;
        }

        public Auth():base()
        { 
        }

        public string Id { get=> id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get  => password; set => password = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Role { get => role; set => role = value; }
      }
}
