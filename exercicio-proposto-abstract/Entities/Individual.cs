using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_proposto_abstract.Entities
{
    class Individual : TaxPay
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Calculo()
        {
            double calculo = 0.0;

            if (AnualIncome < 20000.00)
            {
                calculo = (AnualIncome * 0.15);
            }
            else if (AnualIncome > 20000.00)
            {
                calculo = (AnualIncome * 0.25);
            }

            if (HealthExpenditures > 0.0)
            {
                calculo = calculo - (HealthExpenditures * 0.50);
            }

            return calculo;

        }

        public override string ToString()
        {
            return Name + ": $ " + Calculo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
