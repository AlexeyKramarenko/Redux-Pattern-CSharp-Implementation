using Invoker.Entities;
using Redux.Actions;

namespace Invoker.Actions
{
    public class PhoneActionCreators : IActionCreators
    {
        public IAddItem Add(int id, string name) => new AddPhone(new Phone(id, name));
        public IUpdateItem Update(int id, string name) => new UpdatePhone(new Phone(id, name));
        public IDeleteItem Delete(int id) => new DeletePhone(id);
    }
}
