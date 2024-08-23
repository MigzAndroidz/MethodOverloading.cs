using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class StudentNumber
    {
        public int value;
        public StudentNumber(int initialValue)
        {
            value = initialValue;
        }
         public static StudentNumber operator+(StudentNumber num1, StudentNumber num2)
        {
            
            return new StudentNumber(num1.value + num2.value);
        }

        public static bool operator &(StudentNumber num1, StudentNumber num2)
        {
            return num1.value != 0 && num2.value != 0;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}
