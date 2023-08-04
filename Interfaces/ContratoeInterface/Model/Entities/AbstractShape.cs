using ContratoeInterface.Model.Enums;

namespace ContratoeInterface.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
