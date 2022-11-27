namespace Wasp
{
    public interface IStoreItem
    {
        public double Price { get; set; }
        void DiscountPrice(int percent);
    }
}
