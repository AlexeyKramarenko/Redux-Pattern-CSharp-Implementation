using System.Collections.Generic;

namespace Redux.Storage
{
    public class State : List<IEntity>
    {
        public State()
        {

        }
        public State(IEnumerable<IEntity> entities) : base(entities)
        {

        }
    }
}
