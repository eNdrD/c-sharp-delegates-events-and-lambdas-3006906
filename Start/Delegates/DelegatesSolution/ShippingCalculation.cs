using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesSolution
{
    public abstract class ShippingCalculation
    {
        protected bool _isRisky;
        protected double _riskyFee = 25.0;
        protected double _shippingFee;

        public virtual double Calculate(double price)
        {
            return price * _shippingFee + (_isRisky ? _riskyFee : 0);
        }

    }

    public class ShippingCalculationZone1 : ShippingCalculation
    {
        public ShippingCalculationZone1() : base()
        {
            _isRisky = false;
            _shippingFee = 0.25;
        }
    }

    public class ShippingCalculationZone2 : ShippingCalculation
    {
        public ShippingCalculationZone2() : base()
        {
            _isRisky = true;
            _shippingFee = 0.12;
        }
    }
    public class ShippingCalculationZone3 : ShippingCalculation
    {
        public ShippingCalculationZone3() : base()
        {
            _isRisky = false;
            _shippingFee = 0.08;
        }
    }
    public class ShippingCalculationZone4 : ShippingCalculation
    {
        public ShippingCalculationZone4() : base()
        {
            _isRisky = true;
            _shippingFee = 0.04;
        }
    }
}
