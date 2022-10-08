using Redux.Actions;

namespace ReduxImplementation.Actions
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
