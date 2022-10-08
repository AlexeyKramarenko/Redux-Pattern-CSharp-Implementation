using Redux;
using Redux.Actions;
using Invoker.Entities;

namespace Invoker.Actions
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
