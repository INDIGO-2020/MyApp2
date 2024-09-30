using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvgncMoney
{

    /* Aku ingin kamu tahu bahwa coding dibawah ini merupakan factory Method;
     * dimana kita ingin constructor kita terlihat rapih dan logika pemograman dilakukan
     * ditempat lain. itulah penjelasan yang semoga masuk akal.
     */

    public class ListCurrency
    {
        private List<ModelCurrency> storedCurrency;

        public ListCurrency()
        {
            storedCurrency = new List<ModelCurrency>();
        }

        private List<ModelCurrency> newCurrencyList()
        {
            return new List<ModelCurrency>
            {
                new ModelCurrency("IDR", "Indonesian Rupiah", 15110.00),
                new ModelCurrency("USD", "United State Dollar", 1.00 ),
                new ModelCurrency("SGD", "Singapore Dollar", 11770.00),
                new ModelCurrency("EUR", "Euro", 16840.00)
            };
        }

        public double Convert(string fromCode, string toCode, double amount)
        {

        }
    }
}
