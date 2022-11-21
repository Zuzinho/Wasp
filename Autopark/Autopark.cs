namespace Wasp
{
    public class Autopark
    {
        private string _autoparkName;
        private List<Car> _cars;

        public Autopark(string autoparkName, List<Car> cars)
        {
            _autoparkName = autoparkName;
            _cars = cars;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Car car in _cars)
            {
                result += car.ToString() + '\n';
            }
            return result;
        }
    }
}
