namespace TDDByExample
{
    public interface IExpression
    {
        Money Reduce(Bank source, string to);
        IExpression Plus(IExpression addend);
        IExpression Times(int multiplier);
    }
}