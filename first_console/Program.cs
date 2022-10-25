namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            var input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old");
        }
    }
}
