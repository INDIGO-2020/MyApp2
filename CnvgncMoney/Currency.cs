using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnvgncMoney
{
    public class Currency
    {
        private ConvertCurrency _converter;
        private bool stateProgram = false;
        private char inputUser;
        public Currency()
        {
            _converter = new ConvertCurrency();
        }
        public void Execute()
        {
            string fromCurrency = null;
            string toCurrency = null;
            double amount = 0;
            double hasilKonversi = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("Selamat datang di Aplikasi Tukar Uang\n");

                _converter.DisplayAvailableVA();

                Console.Write("\nKode Mata Uang yang akan dikonversi: ");
                fromCurrency = Console.ReadLine().ToUpper();

                Console.Write("\nKode Mata Uang tujuan: ");
                toCurrency = Console.ReadLine().ToUpper();

                if(!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid Input...");
                    return;
                }

                try
                {
                    hasilKonversi = _converter.Convert(fromCurrency, toCurrency, amount);
                    Console.WriteLine($"{fromCurrency} {amount} = {toCurrency} {hasilKonversi:F2}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                Console.Write("Mau Coba menukar Lagi? (Y/N): ");
                inputUser = char.Parse(Console.ReadKey(false).KeyChar.ToString().ToLower());
                if (inputUser == 'y')
                    stateProgram = true;
                else if (inputUser == 'n')
                    stateProgram = false;
                else
                {
                    Console.WriteLine("\nPerintah tidak ditemukan, aplikasi ditutup");
                    stateProgram = false;
                }

            } while (stateProgram);

        }
    }
}
