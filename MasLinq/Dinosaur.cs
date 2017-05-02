using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MasLinq
{
    public class Dinosaur
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}
