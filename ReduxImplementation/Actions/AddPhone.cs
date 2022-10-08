using Redux;
using Redux.Actions;
using ReduxImplementation.Entities;

namespace ReduxImplementation.Actions
{
    public class AddPhone : IUpdateItem
    {
        public IEntity Entity { get; }

        public AddPhone(Phone phone)
        {
            Entity = phone;
        }
    }
}
