using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Convert {
    class Program {
        static void Main(string[] args) {
            const double crossUahToUsd = 27.5;
            const double crossUahToEur = 30.3;
            const double crossUsdToEur = crossUahToEur / crossUahToUsd;
            Console.Write("From currency (uah, usd, eur): ");
            string fromCurrency = Console.ReadLine();
            string toCurrency = fromCurrency;
            do {
                Console.Write("To currency (uah, usd, eur): ");
                toCurrency = Console.ReadLine();
            }
            while (toCurrency == fromCurrency);

            Console.Write("Amount: ");
            double currAmount = Convert.ToDouble(Console.ReadLine());

            double priceCross = 0;
            switch (fromCurrency) {
                case "uah":
                switch (toCurrency) {
                    case "uah":
                    priceCross = 1;
                    break;
                    case "usd":
                    priceCross = 1/crossUahToUsd;
                    break;
                    case "eur":
                    priceCross = 1/crossUahToEur;
                    break;
                };
                break;
                case "usd":
                switch (toCurrency) {
                    case "uah":
                    priceCross = crossUahToUsd;
                    break;
                    case "usd":
                    priceCross = 1;
                    break;
                    case "eur":
                    priceCross = crossUsdToEur;
                    break;
                };
                break;
                case "eur":
                switch (toCurrency) {
                    case "uah":
                    priceCross = crossUahToEur;
                    break;
                    case "usd":
                    priceCross = 1/crossUsdToEur ;
                    break;
                    case "eur":
                    priceCross = 1;
                    break;
                };
                break;
            };
            double toAmount = priceCross * currAmount;
            Console.WriteLine("{0} {1} = {2} {3}", currAmount, fromCurrency, toAmount, toCurrency);
            Console.ReadLine();
        }
    }
}
