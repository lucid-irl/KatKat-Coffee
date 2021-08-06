using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatKat_Coffee.DataObject
{
    class Pet
    {
        public int Id { set; get; }
        public String name { set; get; }
        public String color { set; get; }
        public String gender { set; get; }
        public String species { set; get; }
        public String owner { set; get; }
        public Pet(int Id, String name, String color, String species, String gender, String owner)
        {
            this.Id = Id;
            this.name = name;
            this.color = color;
            this.species = species;
            this.gender = gender;
            this.owner = owner;
        }
    }
}
