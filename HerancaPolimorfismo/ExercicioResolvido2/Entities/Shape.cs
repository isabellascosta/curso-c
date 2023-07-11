using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioResolvido2.Entities.Enums;

namespace ExercicioResolvido2.Entities
{
    abstract class Shape
    {
        public Color color  { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }


        public abstract double Area();
    }
}
