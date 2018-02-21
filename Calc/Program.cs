using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {

            ILogger logger = new FileLogger();
            List<I3DObject> objects = new List<I3DObject>();

            I3DObject krychle = new Cube(logger, "Kr1");
            krychle.SetParameters(new double[] { 5 });
            objects.Add(krychle);

            I3DObject kvadr = new Cuboid(logger, "Kv1");
            kvadr.SetParameters(new double[] { 5, 6, 7 });
            objects.Add(kvadr);

            objects.ForEach(x =>
            {
                x.GetArea();
                x.GetVolume();
            });

            //Console.ReadKey();
        }
    }
}
