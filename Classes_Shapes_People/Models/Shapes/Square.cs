using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Shapes
{
    public class Square: Shape
    {
        public override string Type { get { return "I am a Square"; } }
        public override Colors Color { get; }
        public double Side { get; set; }
        public Square(double side, Colors color)
        {
            this.Side = side;
            this.Color = color;
        }

        public override double Area
        {
            get
            {
                return Math.Pow(Side, 2);
            }
        }

        public override void AbstractTest()
        {
            throw new NotImplementedException();
        }

        public override string Information()
        {
            return "I am from Square ->" + base.Information();
        }
    }
}
