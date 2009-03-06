namespace TDDByExample
{
    public class Dollar:Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

       

        public Dollar times(int multipler)
        {
            return new Dollar(multipler*Amount);
        }

       
    }
}