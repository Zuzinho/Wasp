namespace Wasp
{
    public class Truck: Car
    {
        private int _maxLoadCapacity;
        private string _driverFullName;
        private Dictionary<string, int> _currentLoad;

        public Truck(string mark, int power, int productionYear,int maxLoadCapacity, string driverFullName): base(mark, power, productionYear)
        {
            _maxLoadCapacity = maxLoadCapacity;
            _driverFullName = driverFullName;
            _currentLoad = new Dictionary<string, int>();
        }

        public void SetDriverFullName(string driverFullName)
        {
            _driverFullName = driverFullName;
        }

        public void AddLoad(string loadName, int weight)
        {
            _currentLoad.Add(loadName, weight);
        }

        public void RemoveLoad(string loadName)
        {
            if (!_currentLoad.Remove(loadName))
            {
                Console.WriteLine("Error, no such load");
            }
        }

        public void PrintCurrentLoad()
        {
            foreach(var pair in _currentLoad)
            {
                Console.WriteLine(string.Format("Name of load - {0}, weight of load - {1}",pair.Key,pair.Value));
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", max load capacity - {_maxLoadCapacity}, full name of driver - {_driverFullName}";
        }
    }
}
