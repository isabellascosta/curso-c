
using System.Globalization;
using ContratoeInterface.Model.Enums;

namespace ContratoeInterface.Model.Entities
{
   class Retangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
                return " retangle color= "
                + Color
                + ", width= "
                + Width.ToString("f2", CultureInfo.InvariantCulture)
                + ", Height= "
                +Height.ToString("f2", CultureInfo.InvariantCulture)
                + ", area= "
                + Area().ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
