namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int a))
            {
                Console.WriteLine($"Area: {a * a}");
                Console.WriteLine($"Perimeter: {a * 4}");
            }
            else
            {
                Console.WriteLine("Please, enter an integer value");
            }
        }
    }
}