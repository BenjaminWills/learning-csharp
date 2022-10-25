namespace interactive_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the addition calculator");
            Console.WriteLine("Input an integer");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input an integer");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}");
        }
    }
}
