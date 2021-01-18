using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_7.Class
{
    public interface Interface1
    {
        // имя, номер зачетки, группа, курс, оплатил (да/нет), выпустился (да/нет).
        string name { get; set; }
        string num_name { get; set; }
        string grupp { get; set; }
        string pay { get; set; }
        string vupusk { get; set; }
    }
}
