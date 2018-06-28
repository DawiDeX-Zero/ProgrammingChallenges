using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    class Length
    {
        const float nmUm = 1000;
        const float umMm = 1000;
        const float mmCm = 10;
        const float cmDm = 10;
        const float dmM = 10;
        const float mKm = 1000;

        const float cmInch = 2.54f;
        const float mMn = 1852;

        const float inchFt = 12;
        const float ftYd = 3;
        const float ydFm = 2;
        const float ftMile = 5280;


        public static readonly ObservableCollection<string> units = new ObservableCollection<string> { "nm","um","mm", "cm", "dm", "m", "km","in","ft","yd","fm","mile","mn" };
        public double nm;
        public double um;
        public double mm;
        public double cm;
        public double dm;
        public double m;
        public double km;
        //other units
        public double inch; //cal
        public double ft;   //foot
        public double yd;   //yard
        public double fm;   //fantom
        public double mil;  //mile
        public double mn;   //nautical mile

        public Length(string unit, double value)
        {
            switch (unit)
            {
                case "nm":
                    this.nm = value;

                    this.um = this.nm / nmUm;
                    this.mm = this.um / umMm;
                    this.cm = this.mm / mmCm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "um":
                    this.um = value;

                    this.nm = this.um * nmUm;

                    this.mm = this.um / umMm;
                    this.cm = this.mm / mmCm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "mm":
                    this.mm = value;

                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;

                    this.cm = this.mm / mmCm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "cm":
                    this.cm = value;

                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;

                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "dm":
                    this.dm = value;

                    this.cm = this.dm * cmDm;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;

                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "m":
                    this.m = value;

                    this.dm = this.m * dmM;
                    this.cm = this.dm * cmDm;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;

                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "km":
                    this.km = value;

                    this.m = this.km * mKm;
                    this.dm = this.m * dmM;
                    this.cm = this.dm * cmDm;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "in":
                    this.inch = value;

                    this.cm = this.inch * cmInch;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    this.mn = this.m / mMn;
                    break;
                case "ft":
                    this.ft = value;

                    this.inch = this.ft * inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;

                    this.cm = this.inch * cmInch;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.mn = this.m / mMn;
                    break;
                case "yd":
                    this.yd = value;

                    this.ft = this.yd * ftYd;
                    this.inch = this.ft * inchFt;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;

                    this.cm = this.inch * cmInch;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.mn = this.m / mMn;
                    break;
                case "fm":
                    this.fm = value;

                    this.yd = this.fm * ydFm;
                    this.ft = this.yd * ftYd;
                    this.inch = this.ft * inchFt;
                    this.mil = this.ft / ftMile;

                    this.cm = this.inch * cmInch;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.mn = this.m / mMn;
                    break;
                case "mile":
                    this.mil = value;

                    this.ft = this.mil * ftMile;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.inch = this.ft * inchFt;

                    this.cm = this.inch * cmInch;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;
                    this.dm = this.cm / cmDm;
                    this.m = this.dm / dmM;
                    this.km = this.m / mKm;

                    this.mn = this.m / mMn;
                    break;
                case "mn":
                    this.mn = value;

                    this.m = this.mn * mMn;
                    this.dm = this.m * dmM;
                    this.cm = this.dm * cmDm;
                    this.mm = this.cm * mmCm;
                    this.um = this.mm * umMm;
                    this.nm = this.um * nmUm;

                    this.km = this.m / mKm;

                    this.inch = this.cm / cmInch;
                    this.ft = this.inch / inchFt;
                    this.yd = this.ft / ftYd;
                    this.fm = this.yd / ydFm;
                    this.mil = this.ft / ftMile;
                    break;
            }
        }
    }
}
