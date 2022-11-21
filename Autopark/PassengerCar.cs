namespace Wasp
{
    public class PassengerCar: Car
    {
        private int _passengersCount;
        private Dictionary<string, int> _repairBook;

        public PassengerCar(string mark, int power, int productionYear,int passengersCount): base(mark, power, productionYear)
        {
            _passengersCount = passengersCount;
            _repairBook = new Dictionary<string, int>();
        }

        public void AddSparePart(string sparePart,int replacementYear = 2022)
        {
            _repairBook.Add(sparePart, replacementYear);
        }

        public int GetReplacementYear(string sparePart)
        {
            try
            {
                return _repairBook[sparePart];
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void PrintRepairBook()
        {
            foreach(var pair in _repairBook)
            {
                Console.WriteLine(string.Format("Spare part - {0}, year of replacement - {1}",pair.Key, pair.Value));
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", count of passengers - {0}",_passengersCount);
        }
    }
}
