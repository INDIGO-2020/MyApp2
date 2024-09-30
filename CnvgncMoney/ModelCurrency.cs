using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvgncMoney
{
    public class ModelCurrency
    {
        public ModelCurrency(string _code, string _name, double _rateAmount)
        {
            Code = _code;
            Name = _name;
            rateAmount = _rateAmount;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public double rateAmount { get; set; }

        public double convertToIDR(double _amount)
        {
            return _amount / rateAmount;
        }

        public double convertFromIDR(double _amountInIDR)
        {
            return _amountInIDR * rateAmount;
        }
    }

}
