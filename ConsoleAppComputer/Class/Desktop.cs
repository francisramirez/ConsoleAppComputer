
namespace ConsoleAppComputer.Class
{
    public sealed class Desktop : Computer
    {
        public string? Monitor { get; set; } 
        public string? Keyboard { get; set; }
        public string? Mouse { get; set; }

       public override void Run()
       {
            // Implementation for running a desktop computer
            Console.WriteLine($"Running {Brand} {Model} with {Processor}, {RAM}GB RAM, {Storage}GB Storage, " +
                              $"OS: {OperatingSystem}, Monitor: {Monitor}, Keyboard: {Keyboard}, Mouse: {Mouse}");
        }
    }
}
