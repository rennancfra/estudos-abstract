using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_proposto_abstract.Entities
{
    abstract class TaxPay
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPay(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Calculo();

        public override string ToString()
        {
            return Name + ": $ " + Calculo().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
