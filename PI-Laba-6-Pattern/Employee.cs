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
                this.AutoAssignBonus();
            }
        }
        public void AutoAssignBonus()
        {
            switch (WorkYears)
            {
                case 1:
                    this.SetBonus(10);
                    break;
                case 2:
                    this.SetBonus(20);
                    break;
                case 3:
                    this.SetBonus(50);
                    break;

                default: 
                    break;
            }
        }

        public void SetBonus(ushort bonus)
        {
            Bonus = bonus;
        }
    }
}
