namespace Wasp
{
    public class DVD: Disk
    {
        private string _producer;
        private string _filmCompany;
        private int _minutesCount;

        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            _producer = producer;
            _filmCompany = filmCompany;
            _minutesCount = minutesCount;
        }

        public override int DiskSize { get => ((_minutesCount / 64)*2); }

        public override void Burn(params string[] values)
        {
            try
            {
                genre = values[4];
                name = values[3];
                _minutesCount = Convert.ToInt32(values[2]);
                _filmCompany = values[1];
                _producer = values[0];
                burnCount++;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Not enough parametrs");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect parametr 'count of songs'");
            }
        }

        public override string ToString()
        {
            return $"Name - {name}, genre - {genre}, producer - {_producer}, film company - {_filmCompany}, count of minutes - {_minutesCount}, count of burns - {burnCount}";
        }
    }
}
