using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15超市收银系统
{
    /// <summary>
    /// 产品
    /// </summary>
    class ProductFatter
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }

        public ProductFatter(string id, int price, string name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
