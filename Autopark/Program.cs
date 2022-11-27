namespace Wasp
{
    public class Program
    {
        public static void Main()
        {
            PassengerCar passengerCar1 = new("AUDI", 100, 2007, 4);
            Truck truck1 = new("Mercedes",400,2001,3000,"Зубенко Михаил Петрович");
            Car passengerCar2 = new PassengerCar("Ferrari",420,2019,2);
            Truck truck2 = new("Autovaz", 410, 2010, 3700, "Иванов Иван Иванович");

            Autopark autopark = new("Autopark",
                passengerCar1,
                truck1,
                passengerCar2,
                truck2);

            Console.WriteLine(autopark.ToString());
        }
    }
}
