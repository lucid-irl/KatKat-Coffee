using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatKat_Coffee.DataObject
{
    class User
    {
        public int Id { set; get; }
        public String username { set; get; }
        public String password { set; get; }
        public String name { set; get; }
        public String gender { set; get; }
        public Int64 age { set; get; }
        public String role { set; get; }
        public User(int Id, String username, String password, String name, String gender, Int64 age, String role)
        {
            this.Id = Id;
            this.username = username;
            this.password = password;
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.role = role;
        }
    }
}
