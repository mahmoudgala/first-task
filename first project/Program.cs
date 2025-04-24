namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small = 25;
            int large = 35;
            double tax = 0.06;
            double cost;
            Console.WriteLine("Enter the number of small carpet");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of the large carpet");
            int num2 =Convert.ToInt32(Console.ReadLine());
            cost= ((num1 *small) + (num2 *large));
            double total_tax= cost *tax;
            double totale= total_tax + cost;
            Console.WriteLine($"Total estimate:${totale}  Estimates are valid for 30 days");


        }
    }
}
