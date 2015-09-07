namespace BuilderPattern
{
    public class MacBuilder : IComputerBuilder
    {
        private readonly Computer computer;

        public MacBuilder()
        {
            this.computer = new Computer("MacBook");
        }

        public void BuildScreenSize()
        {
            this.computer.ScreenSize = ScreenSize.Large;
        }

        public void BuildScreenTouch()
        {
            this.computer.Touch = ScreenTouch.Yes;
        }

        public void BuildMemory()
        {
            this.computer.Memory = MemorySize.Large;
        }

        public void BuildOperatingSystem()
        {
            this.computer.Os = OperatingSystem.Mac;
        }

        public Computer Computer
        {
            get { return this.computer; }
        }
    }

    public class WindowsBuilder : IComputerBuilder
    {
        private readonly Computer computer;

        public WindowsBuilder()
        {
            this.computer = new Computer("Dell Inspiron");
        }

        public void BuildScreenSize()
        {
            this.computer.ScreenSize = ScreenSize.Small;
        }

        public void BuildScreenTouch()
        {
            this.computer.Touch = ScreenTouch.No;
        }

        public void BuildMemory()
        {
            this.computer.Memory = MemorySize.Large;
        }

        public void BuildOperatingSystem()
        {
            this.computer.Os = OperatingSystem.Windows;
        }

        public Computer Computer
        {
            get { return this.computer; }
        }
    }
}
