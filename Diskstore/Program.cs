namespace Wasp
{
    public class Program
    {
        public static void Main()
        {
            Store store = new("Disk shop","Pushkina, Kolotushkina");
            _ = new List<Audio>();
            _ = store + new Audio("Jackson", "LA songs", 12, "Thriller", "Pop music");
            _ = store + new Audio("Korzh", "Minsk songs", 10, "Малый повзрослел", "Rap");
            _ = new List<DVD>();
            _ = store + new DVD("Lucas","LucasFilm",120,"Star wars","Fantasy");
            _ = store + new DVD("Lucas", "LucasFilm", 96, "Indiana Jones", "Fantasy");
            Console.WriteLine(store.ToString());
            store.DVDs[0].Burn("Hitchcock","Paramount","100", "Psycho","Horror");
            Console.WriteLine(store.DVDs[0].ToString());
            foreach(Audio audio in store.Audios) {
                Console.WriteLine($"{audio.Name} -> {audio.DiskSize}");
            }
            foreach (DVD dvd in store.DVDs)
            {
                Console.WriteLine($"{dvd.Name} -> {dvd.DiskSize}");
            }
        }
    }
}
