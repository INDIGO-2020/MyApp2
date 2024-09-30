using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvgncMoney
{
    public class ModelCurrency
    {
        public ModelCurrency(string code, string name, double? amount)
        {
            Code = code;
            Name = name;
            Amount = amount;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public double? Amount { get; set; }
    }

}
