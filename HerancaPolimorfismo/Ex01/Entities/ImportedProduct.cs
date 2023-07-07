using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Entities
{
     class ImportedProduct: Product
    {
        public double CostumFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct( string name, double price, double costumFee):base (name,price)
        {
            CostumFee = costumFee;
        }

        public double TotalPrice()
        {
            return Price + CostumFee;
        }
        public override string priceTag()
        {
            return base.Name + " $" + TotalPrice().ToString("f2",CultureInfo.InvariantCulture) + " (Costum fee: $"+CostumFee.ToString("f2",CultureInfo.InvariantCulture)+") ";
            
        }
    }
}
