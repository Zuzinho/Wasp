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
            return string.Format("Car`s mark - {0}, power - {1}, year of production - {2}",mark,power,productionYear);
        }
    }
}
