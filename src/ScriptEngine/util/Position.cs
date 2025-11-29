using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchNet
{
    public struct Position
    {
        public Position(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; internal set; }
        public double Y { get; internal set; }
    
    }
}
