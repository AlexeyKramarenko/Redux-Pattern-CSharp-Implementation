using Redux;
using Redux.Actions;
using Invoker.Entities;

namespace Invoker.Actions
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
