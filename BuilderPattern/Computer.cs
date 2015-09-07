namespace BuilderPattern
{
    public class Computer
    {
        public string productName;

        public Computer(string name)
        {
            this.productName = name;
        }

        public string ComputerName
        {
            get { return this.productName; }
        }

        public ScreenSize ScreenSize { get; set; }

        public MemorySize Memory { get; set; }

        public OperatingSystem Os { get; set; }

        public ScreenTouch Touch { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}\nScreen: {1}\nTouchScreen: {2}\nOperating System: {3}\nRAM: {4}", this.ComputerName, this.ScreenSize, this.Touch, this.Os, this.Memory)
        }
    }
}
