using Method_Abstract.Entities.Enums;

namespace Method_Abstract.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
