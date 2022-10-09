namespace Redux.Actions
{
    public interface IActionCreators
    {
        IAddItem Add(int id, string name);
        IDeleteItem Delete(int id);
        IUpdateItem Update(int id, string name);
    }
}