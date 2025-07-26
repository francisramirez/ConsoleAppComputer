using ConsoleAppComputer.Class;

namespace ConsoleAppComputer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Laptop laptop = new Laptop("8 hours")
            {
                Brand = "Apple",
                Model = "MacBook Pro",
                Processor = "M1 Pro",
                RAM = 16,
                Storage = 512,
                OperatingSystem = "macOS Monterey"
            };

            laptop.DisplayInfo();

            Console.WriteLine("Hello, World!");
            HelperComputer.GetComputerInfo(
                new Laptop("10 hours") 
                { 
                    Brand = "Dell", 
                    Model = "XPS 13", 
                    Processor = "Intel i7", 
                    RAM = 16, 
                    Storage = 512, 
                    OperatingSystem = "Windows 11" });
        }
    }
    
   
   
}
