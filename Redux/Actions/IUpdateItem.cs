namespace Redux.Actions
{
    public interface IUpdateItem : IAction
    {
        IEntity Entity { get; }
    }
}
