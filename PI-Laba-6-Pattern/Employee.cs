using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Laba_6_Pattern
{
    public class Employee
    {
        // все скрыть и сделать методы доступа
        public sbyte WorkYears { get; set; }
        public ushort Bonus { get; protected set; }
        public Employee(sbyte WY) 
        { 
            if (WY < 0) 
            { 
                Console.WriteLine("Стаж должен быть не меньше 0.");
            }
            else
            {
                WorkYears = WY;
            }
        }
    }
}
