namespace Wasp
{
    public class Audio: Disk
    {
        private string _artist;
        private string _recordingStudio;
        private int _songsNumber;

        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name,genre)
        {
            _artist = artist;
            _recordingStudio = recordingStudio;
            _songsNumber = songsNumber;
        }
        public override int DiskSize { get => _songsNumber * 8; }

        public override void Burn(params string[] values)
        {
            try
            {
                genre = values[4];
                name = values[3];
                _songsNumber = Convert.ToInt32(values[2]);
                _recordingStudio = values[1];
                _artist = values[0];
                burnCount++;
            }
            catch(IndexOutOfRangeException)
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
            return $"Name - {name}, genre - {genre}, artist - {_artist}, recording studio - {_recordingStudio}, count of songs - {_songsNumber}, count of burns - {burnCount}";
        }
    }
}
