namespace Wasp
{
    public class Disk: IStoreItem
    {
        protected string name;//Как я понимаю, это - название альбома
        protected string genre;//А это - жанр альбома
        protected int burnCount;

        public string Name { get { return name; } private set { name = value; } }
        public string Genre { get { return genre; } private set { genre = value; } }

        public virtual int DiskSize { get; set; }
        public double Price { get; set; }

        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
            burnCount = 0;
        }

        public virtual void Burn(params string[] values) { }

        public void DiscountPrice(int percent)
        {
            Price *= ((100 - percent)/100.0);
        }
    }
}
