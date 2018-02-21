using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    /// <summary>
    /// Template for 3D object
    /// </summary>
    abstract class A3Dobject : I3DObject
    {
        internal ILogger logger;
        private bool _parametersSet = false;

        internal bool ParametersSet
        {
            get { return _parametersSet; }
            private set { _parametersSet = value; }

        }
        public string Name { get; set; }
        private A3Dobject()
        {
        }

        public A3Dobject(ILogger logger)
        {
            this.logger = logger;
        }
        internal void SetParamatersDone()
        {
            _parametersSet = true;
        }

        internal abstract double CalculateVolume();
        internal abstract double CalculateArea();
        public abstract void SetParameters(double[] parameters);

        internal void ValidateParameters(double[] parameters, int count)
        {
            bool checkOk = true;

            if (parameters.Count() != count)
            {
                checkOk = false;

            }

            foreach (var item in parameters)
            {

                if (item < 0.0)
                {
                    checkOk = false;
                    break;
                }
            }

            if (!checkOk)
            {
                logger.LogIt("Parameters validation failed.");
                throw new Exception("Wrong parameters.");
            }
        }

        internal void CheckParameters()
        {
            if (!_parametersSet)
            {
                logger.LogIt("Parameters checking failed.");
                throw new Exception("Paramaters not set.");
            }
                
        }

        public double GetVolume()
        {
            return CalculateVolume();
        }

        public double GetArea()
        {
            return CalculateArea();
        }
    }
}
