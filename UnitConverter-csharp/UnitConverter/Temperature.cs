using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Temperature
    {
        const float fC = 1.8f;
        const float fC_add = 32;
        const float cK = 273.15f;

        public static readonly ObservableCollection<string> units = new ObservableCollection<string> { "C","F","K"};
        public double c;
        public double f;
        public double k;


        public Temperature(string unit, double value)
        {
            switch (unit)
            {
                case "C":
                    this.c = value;

                    this.f = this.c * fC + fC_add;
                    this.k = this.c + cK;
                    break;
                case "F":
                    this.f = value;

                    this.c = (this.f - fC_add)/fC;
                    this.k = this.c + cK;
                    break;
                case "K":
                    this.k = value;

                    this.c = this.k - cK;
                    this.f = this.c * fC + fC_add;
                    break;
               
            }
        }
    }
}
