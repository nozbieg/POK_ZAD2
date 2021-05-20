using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POK_ZAD2
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double circuit;
        private double field;
        public double Circuit
        {
            get
            {
                circuit = CountCircuit(Radius);
                return circuit;
            }
        }
        public double Field
        {
            get
            {
                field = CountField(Radius);
                return field;
            }
        }

        public double Radius { get; set; }

        double CountCircuit(double radius)
        {
            var circuit = 2 * Math.PI * radius;
            return circuit;
        }
        double CountField(double radius)
        {
            var field = Math.PI * Math.Pow(Radius, 2);
            return field;
        }
        public override string ToString()
        {
            return "Circle Radius is: " + Radius + ", Circle Field is: " + Field + ", Circle Circuit is: " + Circuit;
        }
    }
}
