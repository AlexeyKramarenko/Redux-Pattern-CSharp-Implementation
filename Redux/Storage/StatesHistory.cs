using System.Collections.Generic;

namespace Redux.Storage
{
    public class StatesHistory : List<State>
    {
        public StatesHistory()
        {
            this.Add(new EmptyState());
        }

        private class EmptyState : State
        {
        }
    }
}
