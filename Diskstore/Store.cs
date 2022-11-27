namespace Wasp
{
    public class Store
    {
        private string _storeName;
        private string _address;
        private List<Audio> _audios;
        private List<DVD> _dVDs;

        public List<Audio> Audios { get
            {
                return _audios;
            }
        }

        public List<DVD> DVDs { get
            {
                return _dVDs;
            } }

        public Store(string storeName, string address)
        {
            _storeName = storeName;
            _address = address;
            _audios = new List<Audio>();
            _dVDs = new List<DVD>();
        }

        public static List<Audio> operator +(Store store, Audio audio)
        {
            store._audios.Add(audio);
            return store._audios;
        }

        public static List<Audio> operator -(Store store, Audio audio)
        {
            store._audios.Remove(audio);
            return store._audios;
        }

        public static List<DVD> operator +(Store store, DVD dvd)
        {
            store._dVDs.Add(dvd);
            return store._dVDs;
        }

        public static List<DVD> operator -(Store store, DVD dvd)
        {
            store._dVDs.Remove(dvd);
            return store._dVDs;
        }

        public override string ToString()
        {
            string result = $"Store {_storeName} at {_address} contains:\n";
            result += "Audio disks:\n";
            foreach (Audio audio in _audios) result += audio.ToString() + '\n';
            result += "Dvd disks:\n";
            foreach (DVD dvd in _dVDs) result += dvd.ToString() + '\n';
            return result;
        }
    }
}
