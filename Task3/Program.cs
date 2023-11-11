namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (double.TryParse(input, out double r))
            {
                double pi = 3.14;
                double lengthValue = 2 * pi * r;
                double areaValue = pi * r * r;
                double volumeValue = 4 / 3 * pi * r * r * r;
                Console.Write($"length: {lengthValue} \narea: {areaValue} \nvolume: {volumeValue}");
            }
            else
            {
                Console.WriteLine("Please, enter an integer value");
            }
        }
    }
}