using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UnitConverter
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int tabSelected;
        private double valueToConvert;
        private string valueConverted;
        private string convertFrom;
        private string convertTo;
        private readonly ObservableCollection<string> lenunits = Length.units;
        private readonly ObservableCollection<string> massunits = Mass.units;
        private readonly ObservableCollection<string> tempunits = Temperature.units;

        public double ValueToConvert { get => valueToConvert; set { valueToConvert = value; OnPropertyChanged("ValueToConvert"); } } 
        public string ValueConverted { get => valueConverted; set { valueConverted = value; OnPropertyChanged("ValueConverted"); } }

        public string ConvertFrom { get => convertFrom; set { convertFrom = value; OnPropertyChanged("ConvertFrom"); } }
        public string ConvertTo { get => convertTo; set { convertTo = value; OnPropertyChanged("ConvertTo"); } }

        public ObservableCollection<string> LenUnits => Length.units;
        public ObservableCollection<string> MassUnits => Mass.units;
        public ObservableCollection<string> TempUnits => Temperature.units;

        public int TabSelected { get => tabSelected; set { tabSelected = value; OnPropertyChanged("TabSelected"); } }

        private Length len;
        private Mass mass;
        private Temperature temp;
        
        public void Convert()
        {
            switch(tabSelected)
            {
                case 0:
                    len = new Length(ConvertFrom, ValueToConvert);
                    break;
                case 1:
                    mass = new Mass(ConvertFrom, ValueToConvert);
                    break;
                case 2:
                    temp = new Temperature(ConvertFrom, ValueToConvert);
                    break;
            }
            ChangedUnit();
        }
        public void ChangedUnit() //proper formating of text
        {
            switch (ConvertTo)
            {
                case "nm":
                    if (len.nm.ToString("#########.###############")[0] == ',' || len.nm.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.nm.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.nm.ToString("#########.###############");
                    }
                    break;
                case "um":
                    if (len.um.ToString("#########.###############")[0] == ',' || len.um.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.um.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.um.ToString("#########.###############");
                    }
                    break;
                case "mm":
                    if (len.mm.ToString("#########.###############")[0] == ',' || len.mm.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.mm.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.mm.ToString("#########.###############");
                    }
                    break;
                case "cm":
                    if (len.cm.ToString("#########.###############")[0] == ',' || len.cm.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.cm.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.cm.ToString("#########.###############");
                    }
                    break;
                case "dm":
                    if (len.dm.ToString("#########.###############")[0] == ',' || len.dm.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.dm.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.dm.ToString("#########.###############");
                    }
                    break;
                case "m":
                    if (len.m.ToString("#########.###############")[0] == ',' || len.m.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.m.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.m.ToString("#########.###############");
                    }
                    break;
                case "km":
                    if (len.km.ToString("#########.###############")[0] == ',' || len.km.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.km.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.km.ToString("#########.###############");
                    }
                    break;
                case "in":
                    if (len.inch.ToString("#########.###############")[0] == ',' || len.inch.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.inch.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.inch.ToString("#########.###############");
                    }
                    break;
                case "ft":
                    if (len.ft.ToString("#########.###############")[0] == ',' || len.ft.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.ft.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.ft.ToString("#########.###############");
                    }
                    break;
                case "yd":
                    if (len.yd.ToString("#########.###############")[0] == ',' || len.yd.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.yd.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.yd.ToString("#########.###############");
                    }
                    break;
                case "fm":
                    if (len.fm.ToString("#########.###############")[0] == ',' || len.fm.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.fm.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.fm.ToString("#########.###############");
                    }
                    break;
                case "mile":
                    if (len.mil.ToString("#########.###############")[0] == ',' || len.mil.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.mil.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.mil.ToString("#########.###############");
                    }
                    break;
                case "mn":
                    if (len.mn.ToString("#########.###############")[0] == ',' || len.mn.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + len.mn.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = len.mn.ToString("#########.###############");
                    }
                    break;
                //TAB 2 //MASS
                case "mg":
                    if (mass.mg.ToString("#########.###############")[0] == ',' || mass.mg.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.mg.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.mg.ToString("#########.###############");
                    }
                    break;
                case "g":
                    if (mass.g.ToString("#########.###############")[0] == ',' || mass.g.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.g.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.g.ToString("#########.###############");
                    }
                    break;
                case "dag":
                    if (mass.dag.ToString("#########.###############")[0] == ',' || mass.dag.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.dag.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.dag.ToString("#########.###############");
                    }
                    break;
                case "kg":
                    if (mass.kg.ToString("#########.###############")[0] == ',' || mass.kg.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.kg.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.kg.ToString("#########.###############");
                    }
                    break;
                case "q":
                    if (mass.q.ToString("#########.###############")[0] == ',' || mass.q.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.q.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.q.ToString("#########.###############");
                    }
                    break;
                case "t":
                    if (mass.t.ToString("#########.###############")[0] == ',' || mass.t.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.t.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.t.ToString("#########.###############");
                    }
                    break;
                case "gr":
                    if (mass.gr.ToString("#########.###############")[0] == ',' || mass.gr.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.gr.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.gr.ToString("#########.###############");
                    }
                    break;
                case "oz":
                    if (mass.oz.ToString("#########.###############")[0] == ',' || mass.oz.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.oz.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.oz.ToString("#########.###############");
                    }
                    break;
                case "lb":
                    if (mass.lb.ToString("#########.###############")[0] == ',' || mass.lb.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + mass.lb.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = mass.lb.ToString("#########.###############");
                    }
                    break;
                case "C":
                    if (temp.c.ToString("#########.###############")[0] == ',' || temp.c.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + temp.c.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = temp.c.ToString("#########.###############");
                    }
                    break;
                case "F":
                    if (temp.f.ToString("#########.###############")[0] == ',' || temp.f.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + temp.f.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = temp.f.ToString("#########.###############");
                    }
                    break;
                case "K":
                    if (temp.k.ToString("#########.###############")[0] == ',' || temp.k.ToString("#########.###############")[0] == '.')
                    {
                        ValueConverted = "0" + temp.k.ToString("#########.###############");
                    }
                    else
                    {
                        ValueConverted = temp.k.ToString("#########.###############");
                    }
                    break;
            }
        }


        protected void OnPropertyChanged(string name)
        {
            if(name=="ValueToConvert" || name == "ConvertFrom")
            {
                Convert();
            }
            else if(name=="ConvertTo")
            {
                ChangedUnit();
            }
            else if (name == "TabSelected")
            {
                Convert();
            }
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
