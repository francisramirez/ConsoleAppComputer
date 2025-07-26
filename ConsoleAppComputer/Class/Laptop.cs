

namespace ConsoleAppComputer.Class
{
    /// <summary>
    /// Esta clases es para la adm. de las laptops.
    /// </summary>
    public sealed class Laptop : Computer
    {
        public string BatteryLife { get; set; }
        public Laptop(string batteryLife)
        {
            BatteryLife = batteryLife;
        }
        public override void Run()
        {
            ///
            throw new NotImplementedException();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Processor: {Processor}, RAM: {RAM}GB, " +
                              $"Storage: {Storage}GB, OS: {OperatingSystem}, Battery Life: {BatteryLife}");

        }

        public string GetBatteryLife()
        {
            return BatteryLife;
        }
    }
}
