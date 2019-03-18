using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_proposto_abstract.Entities
{
    class Company : TaxPay
    {
        public int Employees { get; set; }

        public Company(string name, double anualIncome, int employees) : base(name,anualIncome)
        {
            Employees = employees;
            
        }

        public override double Calculo()
        {
            double calculo = 0.0;
            if (Employees < 10)
            {
                calculo = (AnualIncome * 0.16);
            }
            else if (Employees > 10)
            {
                calculo = (AnualIncome * 0.14);
            }

            return calculo;
            
        }

        public override string ToString()
        {
            return Name + ": $ " + Calculo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
