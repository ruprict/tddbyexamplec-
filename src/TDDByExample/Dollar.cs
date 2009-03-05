namespace TDDByExample
{
    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        private int Amount { get; set; }

        public Dollar times(int multipler)
        {
            return new Dollar(multipler*Amount);
        }

        public override bool Equals(object obj)
        {
            Dollar other = (Dollar) obj;
            return Amount == other.Amount;
        
        }
    }
}