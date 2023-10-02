using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dz4
{
    class Mountain : GeographicalObject
    {
        private readonly double peak;

        public Mountain(double x, double y, string name, string description, double peak) : base(x, y, name, description)
        {
            if (peak <= 0)
            {
                throw new ArgumentException($"\"{nameof(peak)}\" cannot be less or equal to zero", nameof(peak));
            }

            this.peak = peak;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Highest point = {this.peak} m\n";
        }
    }
}
