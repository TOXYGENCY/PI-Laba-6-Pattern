namespace PI_Laba_6_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e = new Employee(2);
            Console.WriteLine(e.Bonus); // 20
            e.SetBonus(50);
            Console.WriteLine(e.Bonus); // 50
        }
    }
}