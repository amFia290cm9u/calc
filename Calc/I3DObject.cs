using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
    public interface I3DObject
    {
        double GetVolume();
        double GetArea();
        void SetParameters(double[] parameters);
    }

}