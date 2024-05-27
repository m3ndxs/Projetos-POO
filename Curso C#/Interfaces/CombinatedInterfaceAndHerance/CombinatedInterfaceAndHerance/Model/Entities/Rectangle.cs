﻿using System.Globalization;

namespace CombinatedInterfaceAndHerance.Model.Entities
{
    public class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Circle Color: "
                + Color
                + ", Widht: "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", Height: "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area: "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
