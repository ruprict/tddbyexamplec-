namespace TDDByExample
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public void times(int multipler)
        {
            Amount = multipler*Amount;
        }
    }
}