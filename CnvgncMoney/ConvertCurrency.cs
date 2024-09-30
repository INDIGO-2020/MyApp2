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

    public class ConvertCurrency
    {
        private List<ModelCurrency> storedCurrency;

        public ConvertCurrency()
        {
            storedCurrency = newCurrencyList();
        }

        private List<ModelCurrency> newCurrencyList()
        {
            return new List<ModelCurrency>
            {
                new ModelCurrency("IDR", "Indonesian Rupiah", 15110),
                new ModelCurrency("USD", "United State Dollar", 1 ),
                new ModelCurrency("SGD", "Singapore Dollar", 11770),
                new ModelCurrency("EUR", "Euro", 16840)
            };
        }

        public double Convert(string fromCode, string toCode, double amount)
        {
            ModelCurrency fromCurrency = storedCurrency.FirstOrDefault(c => c.Code == fromCode);
            ModelCurrency toCurrency = storedCurrency.FirstOrDefault(c => c.Code == toCode);

            if(fromCurrency == null || toCurrency == null)
            {
                throw new Exception("Mata Uang tidak ditemukan");
            }

            double amountInIDR = fromCurrency.convertToIDR(amount);
            return toCurrency.convertFromIDR(amountInIDR);
        }

        public void DisplayAvailableVA()
        {
            int count = 0;
            Console.WriteLine("Daftar Tukar Valuta Asing: ");
            Console.WriteLine("No. Kode \t Nama Mata Uang");
            Console.WriteLine("==========================");
            foreach (var item in storedCurrency)
            {
                count++;
                Console.WriteLine($" {count}. {item.Code} - {item.Name}");
            }
        }
    }
}
