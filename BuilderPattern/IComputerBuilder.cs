
namespace BuilderPattern
{
    public interface IComputerBuilder
    {
        void BuildScreenSize();
        void BuildScreenTouch();
        void BuildMemory();
        void BuildOperatingSystem();

        Computer Computer { get; }
    }
}
