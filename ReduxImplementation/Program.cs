using Redux;
using Redux.Storage;
using ReduxImplementation.Actions;
using ReduxImplementation.Entities;
using ReduxImplementation.View;
using System;

namespace Invoker
{
    public class Program
    {
        public static void Main()
        {
            var store = Store.Create(new Reducer());

            store.Subscribe(RenderHelper.DisplayStateOnEveryDispatchedAction);

            store.Dispatch(null);
            store.Dispatch(null);
            store.Dispatch(null);
            store.Dispatch(new AddPhone(new Phone(1, "Motorola")));
            store.Dispatch(new AddPhone(new Phone(2, "Sumsung")));
            store.Dispatch(new AddPhone(new Phone(3, "Nokia")));
            store.Dispatch(new DeletePhone(id: 3));
            store.Dispatch(new UpdatePhone(new Phone(2, "APPLE")));
            store.Dispatch(new DeletePhone(id: 2));
            store.Dispatch(new DeletePhone(id: 1));

            Console.ReadKey();
        }
    }
}
