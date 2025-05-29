using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse
{
    public static class MyUtils
    {
        public static int TinhTuoi(this Employee employee) { 
            return DateTime.Now.Year - employee.Birthday.Year + 1;
        }
    }
}
