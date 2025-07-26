

namespace ConsoleAppComputer.Class
{
    public static class HelperComputer
    {
        public static void GetComputerInfo(Computer computer)
        {
            if (computer is Laptop laptop)
            {
                laptop.DisplayInfo();
                Console.WriteLine($"Battery Life: {laptop.GetBatteryLife()}");
            }
            else if (computer is Desktop desktop)
            {
                Console.WriteLine($"Brand: {desktop.Brand}, Model: {desktop.Model}, Processor: {desktop.Processor}, " +
                                  $"RAM: {desktop.RAM}GB, Storage: {desktop.Storage}GB, OS: {desktop.OperatingSystem}, " +
                                  $"Monitor: {desktop.Monitor}, Keyboard: {desktop.Keyboard}, Mouse: {desktop.Mouse}");
            }
        }
    }
}
