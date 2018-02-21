using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    /// <summary>
    /// Cuboid object concrete class
    /// </summary>
    class Cuboid : A3Dobject
    {
        private double _a;
        private double _b;
        private double _c;

        private const int numParameters = 3;

        public Cuboid(ILogger logger, string name) : base(logger)
        {
            base.Name = name;
        }
        internal override double CalculateArea()
        {
            base.CheckParameters();

            double area = (_a * _b + _a * _c + _b * _c) * 2.0;
            logger.LogIt(String.Format("{0} - {1} - area (2*(a*b+b*c+a*c)) calculated: {2}", this.GetType().FullName, Name, area));            
            return area;
            
        }

        internal override double CalculateVolume()
        {
            base.CheckParameters();

            double volume = _a * _b * _c;
            logger.LogIt(String.Format("{0} - {1} - volume (a*b*c) calculated: {2}", this.GetType().FullName, Name, volume));            
            return volume;
            
        }

        public override void SetParameters(double[] parameters)
        {
            try
            {
                base.ValidateParameters(parameters, numParameters);
                _a = parameters[0];
                _b = parameters[1];
                _c = parameters[2];
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
