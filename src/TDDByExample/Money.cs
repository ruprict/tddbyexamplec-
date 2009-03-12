namespace TDDByExample
{
    public class Money:IExpression
    {
        public int Amount { get; set; }

        
        public string Currency { get; protected set; }

        public Money(int amount, string curr)
        {
            Amount = amount;
            Currency = curr;
        }

       
        public override bool Equals(object obj)
        {
            if (!(obj is Money))
                return false;
            Money other = (Money)obj;
            return Amount == other.Amount &&
                other.Currency==Currency;

        }

        public static Money dollar(int i)
        {
            return new Money(i, "USD");
        }

        public static Money franc(int i)
        {
            return new Money(i, "CHF");
        }


        public IExpression times(int multipler)
        {
            return new Money(Amount * multipler, Currency);
        }

        public override string ToString()
        {
            return Amount + " " + Currency;
        }
        public IExpression Plus(IExpression other)
        {
            return new Sum(this,other);
        }

        public IExpression Times(int mulitplier)
        {
            return new Money(Amount*mulitplier, Currency);
        }
        public Money Reduce(Bank source,string to)
        {
            int rate = source.Rate(Currency, to);
            return new Money(Amount/rate, to);
        }
    }
}