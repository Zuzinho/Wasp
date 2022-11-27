namespace Wasp
{
    public class Autopark
    {
        private string _autoparkName;
        private List<Car> _cars;

        public Autopark(string autoparkName, params Car[] cars)
        {
            _autoparkName = autoparkName;
            _cars = cars.ToList();
        }

        public override string ToString()
        {
            string result = $"Autopark {_autoparkName} contains:\n";
            foreach (Car car in _cars) result += car.ToString() + '\n';
            return result;
        }
    }
}
