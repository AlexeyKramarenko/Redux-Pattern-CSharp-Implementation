using System.Linq;
using Redux.Actions;
using Redux.Storage;

namespace Redux
{
    public class Reducer
    {
        public State Reduce<T>(State state, T action)
            where T : class, IAction
        {
            switch (action)
            {
                case IAddItem _action:
                    state.Add(_action.Entity);
                    return state;

                case IDeleteItem _action:
                    var obj = state.FirstOrDefault(a => a.Id == _action.Id);
                    state.Remove(obj);
                    return state;

                case IUpdateItem _action:
                    var obj2 = state.FirstOrDefault(a => a.Id == _action.Entity.Id);
                    if (obj2 != null)
                    {
                        state.Remove(obj2);
                    }
                    state.Add(_action.Entity);
                    return state;

                default:
                    return state;
            }
        }
    }
}
