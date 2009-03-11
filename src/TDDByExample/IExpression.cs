namespace TDDByExample
{
    public interface IExpression
    {
        Money Reduce(Bank source, string to);
    }
}