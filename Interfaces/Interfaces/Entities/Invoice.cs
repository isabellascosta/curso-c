using System.Globalization;

namespace Interfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("f2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("f2", CultureInfo.InvariantCulture)
            + "\n TotalPayment: "
            + TotalPayment.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
