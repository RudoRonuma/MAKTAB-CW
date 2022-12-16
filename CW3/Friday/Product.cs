using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CW3.Friday
{
    public class Product
    {
        public double Weight { get; set; }
        public double Price { get; set; }

        public static bool operator ==(Product a, Product b) =>
            a.Price == b.Price && a.Weight == b.Weight;

        public static bool operator !=(Product a, Product b) =>
            a.Price != b.Price || a.Weight != b.Weight;
    }
}
