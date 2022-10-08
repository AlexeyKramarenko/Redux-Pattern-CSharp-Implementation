using Redux;

namespace ReduxImplementation.Entities
{
    public class Phone : IEntity
    {
        public int Id { get; }
        public string Text { get; }

        public Phone(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
