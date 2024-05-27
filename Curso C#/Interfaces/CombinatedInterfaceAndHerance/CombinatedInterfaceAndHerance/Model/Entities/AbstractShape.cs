using CombinatedInterfaceAndHerance.Model.Enums;

namespace CombinatedInterfaceAndHerance.Model.Entities
{
    public abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
