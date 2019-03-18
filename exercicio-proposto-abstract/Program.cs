using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercicio_proposto_abstract.Entities;
using System.Globalization;

namespace exercicio_proposto_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPay> list = new List<TaxPay>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anual = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    list.Add(new Individual(name,anual,health));
                }
                else if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Employeers: ");
                    int employeers = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Company(name, anual, employeers));
                }
                else if (ch != 'c' || ch != 'i')
                {
                    i--;
                }
            }

            Console.WriteLine("TAXES PAID:");
            double calculototal = 0.0;
            foreach (TaxPay tax in list)
            {
                Console.WriteLine(tax.ToString());
                calculototal = calculototal + tax.Calculo();
            }
            Console.WriteLine("Total Taxes: $ "+ calculototal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();

        }
    }
}
