namespace CarLibrary
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set {  model = value; }
        }
        public int Year
        {
            get { return year;}
            set { year = value; }
        }


        public Car()
        {
            make = "";
            model = "";
            year = 0;
        }
        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        
        public void Drive()
        {
            Console.WriteLine("Driving Strated");
        }
        public void Stop()
        {
            Console.WriteLine("Driving stopped");
        }
    }
}
