using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_7.Class;

namespace WpfApp1.Class
{
    public class Class1 : Interface1
    {
        public string Name;
        public string Num_name;
        public string Grupp;
        public string Pay;
        public string Vupusk;

        public string _name, _grupp, _pay, _vupusk, _num_name;

        public Class1()
        {
            _name = Name;
            _num_name = Num_name;
            _grupp = Grupp;
            _pay = Pay;
            _vupusk = Vupusk;
        }

        public string name { get => _name; set => _name = value; }
        public string num_name { get => _num_name; set => _num_name = value; }
        public string grupp { get => _grupp; set => _grupp = value; }
        public string pay { get => _pay; set => _pay = value; }
        public string vupusk { get => _vupusk; set => _vupusk = value; }
    }
}