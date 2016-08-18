namespace Parkowanie
{
    //{
    //    public class Car
    //    {
    //        public string NameCar;  //{ get; set; }
    //        public string ColorCar; //{ get; set; }

    //        public Car(string namecar, string colorcar)
    //        {
    //            NameCar = namecar;
    //            ColorCar = colorcar;
    //        }   
    //    }
    //}

    public class Car
    {
        private string name;
        private string color;

        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public string getName()
        {
            return name;
        }
        public string getColor()
        {
            return color;
        }
    }
}
