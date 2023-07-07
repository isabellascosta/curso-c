using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Entities
{
    class UsedProduct: Product
    {
        public DateTime ManufactureDate{ get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate):base(name,price)
        {
            ManufactureDate = manufactureDate;
        }
        public override string priceTag()
        {
            return base.Name + " (used) $" + Price.ToString("f2",CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy")+")";
        }
    }
}
