namespace CarManufacturer
{
    class Engine
    {
        private int horsePower;
        private double cubicCapacity;
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
        public int HorsePower
        {
            get { return this.horsePower; }
            private set { this.horsePower = value; }
        }

        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            private set { this.cubicCapacity = value; }
        }
    }
}