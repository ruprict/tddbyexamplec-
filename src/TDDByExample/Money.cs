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


        public Money times(int multipler)
        {
            return new Money(Amount * multipler, Currency);
        }

        public override string ToString()
        {
            return Amount + " " + Currency;
        }
        public Sum plus(Money other)
        {
            return new Sum(this,other);
        }

        public Money Reduce(Bank source,string to)
        {
            int rate = source.Rate(Currency, to);
            return new Money(Amount/rate, to);
        }
    }
}