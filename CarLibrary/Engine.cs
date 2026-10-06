namespace CarLibrary
{
    class Engine
    {
        private int cylinders;
        private double horsepower;

        public int Cylinders
        {
            get {  return cylinders; }
            set { cylinders = value; }
        }
        public double Horsepower
        {
            get { return horsepower; }
            set {  horsepower = value; }
        }

        public Engine()
        {
            cylinders = 0;
            horsepower = 0;
        }
        public Engine(int cylinders, double horsepower)
        {
            this.Cylinders = cylinders;
            this.Horsepower = horsepower;
        }
        
        public void Start()
        {
            Console.WriteLine("Engine Starting");
        }
        public void Stop()
        {
            Console.WriteLine("Engine Stopping");
        }
    }
}
