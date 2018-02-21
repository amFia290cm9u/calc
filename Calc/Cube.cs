using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    /// <summary>
    /// Cube object concrete class
    /// </summary>
    class Cube : A3Dobject
    {
        private double _a;

        private const int numParameters = 1;

        public Cube(ILogger logger, string name) : base(logger)
        {
            base.Name = name;
        }
        internal override double CalculateArea()
        {
            base.CheckParameters();

            double area = 6 * _a * _a;
            logger.LogIt(String.Format("{0} - {1} - area (6 * a ^ 2) calculated: {2}", this.GetType().FullName, Name, area));            
            return area;
            
        }

        internal override double CalculateVolume()
        {
            base.CheckParameters();

            double volume = _a * _a * _a;
            logger.LogIt(String.Format("{0} - {1} - volume (a^3) calculated: {2}", this.GetType().FullName,Name ,volume));
            return volume;
            
        }
        public override void SetParameters(double[] parameters)
        {
            try
            {
                base.ValidateParameters(parameters, numParameters);
                _a = parameters[0];
                SetParamatersDone();
            }
            catch (Exception ex)
            {
                base.logger.LogIt(ex.Message);
                throw;
            }
            
        }

    }
}
