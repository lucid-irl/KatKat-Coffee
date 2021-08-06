using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatKat_Coffee.DataObject
{
    class Item
    {
        public int Id { set; get; }
        public String name { set; get; }
        public String category { set; get; }
        public Int64 price { set; get; }
        public Item(int Id, String name, String category, Int64 price)
        {
            this.Id = Id;
            this.name = name;
            this.category = category;
            this.price = price;
        }
    }
}
