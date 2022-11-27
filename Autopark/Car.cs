namespace Wasp
{
    public class Car
    {
        protected string mark;
        protected int power;
        protected int productionYear;
        
        public Car(string mark, int power, int productionYear)
        {
            this.mark = mark;
            this.power = power;
            this.productionYear = productionYear;
        }

        public override string ToString()
        {
            return $"Car`s mark - {mark}, power - {power}, year of production - {productionYear}";
        }
    }
}
