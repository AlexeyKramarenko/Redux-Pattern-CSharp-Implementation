using Redux.Actions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Redux.Storage
{
    public class Store
    {
        private readonly List<Action<State>> _renderActions = new List<Action<State>>();
        private readonly StatesHistory _statesHistory = new StatesHistory();

        private readonly Reducer _reducer;

        private Store(Reducer reducer)
        {
            _reducer = reducer;
        }
        public static Store Create(Reducer reducer)
        {
            if (reducer == null)
            {
                throw new ArgumentNullException(nameof(reducer));
            }

            return new Store(reducer);
        }

        // Set visualizion method
        public void Subscribe(Action<State> renderAction)
        {
            _renderActions.Add(renderAction);
        }

        // Update state
        public void Dispatch(IAction updateStateAction)
        {
            var newState = _reducer.Reduce(GetState(), updateStateAction);

            _statesHistory.Add(newState);

            VisualizeCurrentState();
        }

        private void VisualizeCurrentState() =>
            _renderActions.ForEach(renderAction => renderAction(GetState()));

        private State GetState() => 
            _statesHistory.Last();
    }
}
