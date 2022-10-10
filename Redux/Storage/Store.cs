using Redux.Actions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Redux.Storage
{
    public class Store
    {

        private readonly List<Action<State>> _renderEntitiesDataMethodsList = new List<Action<State>>();
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


        // Set any entities visualizion method
        public void Subscribe(Action<State> renderEntitesDataMethod)
        {
            _renderEntitiesDataMethodsList.Add(renderEntitesDataMethod);
        }


        // ADD new state (NOT REPLACE/UPDATE IT like in VUEX) and UPDATE view with it (last added state) AT ONCE
        public void Dispatch(IAction updateStateAction)
        {
            State newState = _reducer.Reduce(GetState(), updateStateAction);

            _statesHistory.Add(newState);

            VisualizeCurrentState();
        }


        #region Private Methods 

        private void VisualizeCurrentState() =>
            _renderEntitiesDataMethodsList.ForEach(render => render(GetState()));

        private State GetState() =>
            _statesHistory
                   .Select(state => new State(state))
                   .DefaultIfEmpty(new State())
                   .Last();

        #endregion

    }
}
