using Redux.Actions;

namespace Invoker.Actions
{
    public class DeletePhone : IDeleteItem
    {
        public int Id { get; }

        public DeletePhone(int id)
        {
            Id = id;
        }
    }
}
