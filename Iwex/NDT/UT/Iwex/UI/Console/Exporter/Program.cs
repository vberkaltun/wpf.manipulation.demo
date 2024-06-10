namespace Exporter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(string.Join(" - ", args));

            // Create() creates a file at pathName 
            FileStream fs = File.Create(args[1]);
        }
    }
}
