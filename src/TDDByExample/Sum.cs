namespace TDDByExample
{
    public class Sum:IExpression
    {
        public IExpression Augend { get; private set; }
        public IExpression Addend { get; private set; }

        public Sum(IExpression augend, IExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank,string to)
        {
            int amount = Augend.Reduce(bank,to).Amount + Addend.Reduce(bank,to).Amount;
            return new Money(amount, to);
        }

        public IExpression Plus(IExpression addend)
        {
            return new Sum(this, addend);
        }
        public IExpression Times(int multiplier)
        {
            return new Sum(Augend.Times(multiplier), Addend.Times(multiplier));
        }
    }
}