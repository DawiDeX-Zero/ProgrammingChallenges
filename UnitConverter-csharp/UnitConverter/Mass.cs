using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Mass
    {
        const float mgG = 1000;
        const float gDag = 10;
        const float dagKg = 100;
        const float kgQ = 100;
        const float qT = 10;

        const float lbKg = 0.45359237f;

        const float lbOz = 16;
        const float ozGr = 437.5f;

        public static readonly ObservableCollection<string> units = new ObservableCollection<string> { "mg","g","dag", "kg", "q", "t", "gr", "oz", "lb"};
        public double mg;
        public double g;
        public double dag;
        public double kg;
        public double q; //kwintal
        public double t;
        //other units
        public double gr; //gran
        public double oz; //uncja
        public double lb; //funt

        public Mass(string unit, double value)
        {
            switch (unit)
            {
                case "mg":
                    this.mg = value;

                    this.g = this.mg / mgG;
                    this.dag = this.g / gDag;
                    this.kg = this.dag / dagKg;
                    this.q = this.kg / kgQ;
                    this.t = this.kg / qT;

                    this.lb = this.kg / lbKg;
                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;
                    break;
                case "g":
                    this.g = value;

                    this.mg = this.g * mgG;

                    this.dag = this.g / gDag;
                    this.kg = this.dag / dagKg;
                    this.q = this.kg / kgQ;
                    this.t = this.q / qT;

                    this.lb = this.kg / lbKg;
                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;
                    break;
                case "dag":
                    this.dag = value;

                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;

                    this.kg = this.dag / dagKg;
                    this.q = this.kg / kgQ;
                    this.t = this.q / qT;

                    this.lb = this.kg / lbKg;
                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;
                    break;
                case "kg":
                    this.kg = value;

                    this.dag = this.kg * dagKg;
                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;
 
                    this.q = this.kg / kgQ;
                    this.t = this.q / qT;

                    this.lb = this.kg / lbKg;
                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;
                    break;
                case "q":
                    this.q = value;

                    this.kg = this.q * kgQ;
                    this.dag = this.kg * dagKg;
                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;
     
                    this.t = this.q / qT;

                    this.lb = this.kg / lbKg;
                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;
                    break;
                case "t":
                    this.t = value;

                    this.q = this.t * qT;
                    this.kg = this.q * kgQ;
                    this.dag = this.kg * dagKg;
                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;

                    this.lb = this.kg / lbKg;
                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;
                    break;
                case "gr": //TODO formulas
                    this.gr = value;

                    this.oz = this.gr / ozGr;
                    this.lb = this.oz / lbOz;

                    this.kg = this.lb * lbKg;
                    this.q = this.kg / kgQ;
                    this.t = this.q / qT;
                    this.dag = this.kg * dagKg;
                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;
                    break;
                case "oz":
                    this.oz = value;

                    this.gr = this.oz * ozGr;
                    this.lb = this.oz / lbOz;

                    this.kg = this.lb * lbKg;
                    this.q = this.kg / kgQ;
                    this.t = this.q / qT;
                    this.dag = this.kg * dagKg;
                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;
                    break;
                case "lb":
                    this.lb = value;

                    this.oz = this.lb * lbOz;
                    this.gr = this.oz * ozGr;

                    this.kg = this.lb * lbKg;
                    this.q = this.kg / kgQ;
                    this.t = this.q / qT;
                    this.dag = this.kg * dagKg;
                    this.g = this.dag * gDag;
                    this.mg = this.g * mgG;
                    break;
            }
        }
    }
}
