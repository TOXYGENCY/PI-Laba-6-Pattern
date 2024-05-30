namespace PI_Laba_6_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ImaginaryTech = new Company1();

            var Alex = new Employee(1);
            var Bob = new Employee(2);
            var Evgeniy = new Employee(3);

            ImaginaryTech.AddComp(Alex);
            ImaginaryTech.AddComp(Bob);
            ImaginaryTech.AddComp(Evgeniy);

            // Выборочное назначение стартового бонуса из задания
            foreach (Employee employee in ImaginaryTech.ChildrenList)
            {
                Console.WriteLine("\n-------New Employee Processing-------");
                Console.WriteLine($"The bonus is {employee.Bonus}");
                if (employee.WorkYears > 1 && employee.Bonus != 50)
                {
                    Console.WriteLine($"Setting the bonus to 50...");
                    employee.SetBonus(50);
                    Console.WriteLine($"Now bonus is {employee.Bonus}.");
                }
            }
        }
    }
}