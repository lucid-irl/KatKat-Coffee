using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatKat_Coffee.DataObject
{
    class Bill
    {
        public int Id { set; get; }
        
        public Int64 price { set; get; }
        public String time { set; get; }
        public Bill(int Id, Int64 price, String time)
        {
            this.Id = Id;
            this.price = price;
            this.time = time;
        }
    }
}
