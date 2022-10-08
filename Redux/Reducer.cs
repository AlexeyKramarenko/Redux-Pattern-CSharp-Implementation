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
                    {
                        state.Add(_action.Entity);
                        return state;
                    }

                case IDeleteItem _action:
                    {
                        IEntity entity = state.FirstOrDefault(a => a.Id == _action.Id);
                        if (entity != null)
                        {
                            state.Remove(entity);
                        }
                        return state;
                    }

                case IUpdateItem _action:
                    {
                        IEntity entity = state.FirstOrDefault(a => a.Id == _action.Entity.Id);
                        if (entity != null)
                        {
                            state.Remove(entity);
                        }
                        state.Add(_action.Entity);
                        return state;
                    }

                default:
                    return state;
            }
        }
    }
}
