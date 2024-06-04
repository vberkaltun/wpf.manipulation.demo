namespace Exporter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create() creates a file at pathName 
            FileStream fs = File.Create(args[0]);
        }
    }
}
