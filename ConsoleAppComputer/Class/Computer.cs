
namespace ConsoleAppComputer.Class
{
    public abstract class Computer
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; } // in GB
        public int Storage { get; set; } // in GB
        public string OperatingSystem { get; set; }
        public Computer()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Processor = "Unknown";
            RAM = 0;
            Storage = 0;
            OperatingSystem = "Unknown";
        }

        public abstract void Run();

    }
}
