
using ContratoeInterface.Model.Enums;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ContratoeInterface.Model.Entities
{
    class Circle: AbstractShape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return " circle color= "
                + Color
                + ", radius = "
                + Radius.ToString("f2", CultureInfo.InvariantCulture)
                +", area: "
                +Area().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
