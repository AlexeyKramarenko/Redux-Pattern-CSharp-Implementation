namespace Redux.Actions
{
    public interface IAddItem : IAction
    {
        IEntity Entity { get; }
    }
}
