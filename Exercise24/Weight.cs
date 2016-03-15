using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    enum WeightUnit
    {
        Pound,
        Kilogram
        //Gram
        //Tonne
    }
    class Weight

    {
        WeightUnit u { get; set; }
        double amount { get; set;}

        public Weight(WeightUnit u, double amount)
        {
            this.u = u;
            this.amount = amount;
        }
        public void SetWeight(WeightUnit u, double amount )
        {
            switch (u)
            {
                case WeightUnit.Pound:

                    break;
                case WeightUnit.Kilogram:

                    break;
                default:
                    break;
            }
        }

        public double GetWeight(WeightUnit U)
        { }

        public void Add()
        { }
    }
}
