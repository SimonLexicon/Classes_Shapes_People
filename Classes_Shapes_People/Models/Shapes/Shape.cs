using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Shapes
{
    public abstract class Shape
    {
        public abstract string Type { get; }
        public abstract double Area { get; }
        public abstract Colors Color { get; }

        public virtual string Information()
        {
            return "I am from Shape Class!!";
        }

        // Cannot have a "Body" {}, because its abstract
        public abstract void AbstractTest();
    }
}
