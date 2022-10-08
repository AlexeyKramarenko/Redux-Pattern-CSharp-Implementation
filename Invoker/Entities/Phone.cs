using Redux;

namespace Invoker.Entities
{
    public class Phone : IEntity
    {
        public int Id { get; }
        public string Name { get; }

        public Phone(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
