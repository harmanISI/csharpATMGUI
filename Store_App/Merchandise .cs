using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_App
{
    abstract class Merchandise
    {
        static int Sid = 0;
        public int Price { get; private set; }
        public string Item { get; private set; }
        public int SerialNumber { get; private set; }

        public Merchandise(int _price, string _item)
        {
            this.Price = _price;
            this.Item = _item;
            this.SerialNumber = Sid;
        }
        public abstract String ReturnIteminfo();
       
    }
}
