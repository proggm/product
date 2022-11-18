using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    internal class products
    {
        public products(string name, string price, int expirationdate,int dodo)
        {
            this.name = name;
            this.price = price;
            this.expirationdate = expirationdate;
            this.dodo = dodo;
        }

        public string name { get; set; }
        public string price { get; set; }  
        public int expirationdate { get; set; }
        public int dodo { get; set; }
    }
}
