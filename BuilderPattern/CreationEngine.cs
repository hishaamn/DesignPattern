namespace BuilderPattern
{
    public class CreationEngine
    {
        public void Construct(IComputerBuilder computerBuilder)
        {
            computerBuilder.BuildScreenSize();
            computerBuilder.BuildScreenTouch();
            computerBuilder.BuildOperatingSystem();
            computerBuilder.BuildMemory();
        }
    }
}
