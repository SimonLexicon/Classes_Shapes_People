using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Shapes
{
    public class Circle : Shape
    {
        public override string Type { get { return "I am a Circle"; } }
        public override Colors Color { get; }
        public double radius;
        public Circle(double radius, Colors color)
        {
            this.radius = radius;
            this.Color = color;
        }

        public override double Area { get { 
                return Math.Round(Math.PI * Math.Pow(radius, 2), 2); } }

        public override void AbstractTest()
        {
            throw new NotImplementedException();
        }
    }
}
