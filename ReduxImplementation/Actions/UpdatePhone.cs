using Redux;
using Redux.Actions;
using ReduxImplementation.Entities;

namespace ReduxImplementation.Actions
{
    public class UpdatePhone : IUpdateItem
    {
        public IEntity Entity { get; }
        public UpdatePhone(Phone phone)
        {
            Entity = phone;
        }
    }
}
