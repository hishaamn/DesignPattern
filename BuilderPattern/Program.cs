using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lets create the Director first
            var newManufacturer = new CreationEngine();
            // Lets have the Builder class ready
            IComputerBuilder phoneBuilder = null;

            // Now let us create an android phone
            phoneBuilder = new WindowsBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Computer.ToString());

            // Now let us create a Windows Phone
            phoneBuilder = new MacBuilder();
            newManufacturer.Construct(phoneBuilder);
            Console.WriteLine("A new Phone built:\n\n{0}", phoneBuilder.Computer.ToString());

            Console.ReadLine();
        }
    }
}
