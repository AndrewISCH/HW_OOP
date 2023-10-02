using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default;

internal interface IGeographicalObject
{
    string Name { get; }

    string Description { get; }

    double X { get; }

    double Y { get; }

    string GetInfo();
}
