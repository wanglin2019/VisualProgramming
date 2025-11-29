using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchNet
{
    public struct Position
    {
        public Position(double v1, double v2) : this()
        {
            V1 = v1;
            V2 = v2;
        }

        public string X { get; internal set; }
        public string Y { get; internal set; }
        public double V1 { get; }
        public double V2 { get; }
    }
}
