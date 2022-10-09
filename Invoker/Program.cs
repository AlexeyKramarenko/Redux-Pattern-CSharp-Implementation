using Invoker.Factories;
using Invoker.View;
using Redux;
using Redux.Storage;
using System;

namespace Invoker
{
    public class Program
    {
        public static void Main()
        {
            var actionCreators = new PhoneActionCreators();

            var store = Store.Create(new Reducer());

            store.Subscribe(RenderHelper.DisplayState);

            store.Dispatch(null);
            store.Dispatch(null);
            store.Dispatch(null);
            store.Dispatch(actionCreators.Add(1, "Motorola"));
            store.Dispatch(actionCreators.Add(2, "Sumsung"));
            store.Dispatch(actionCreators.Add(3, "Nokia"));
            store.Dispatch(actionCreators.Delete(id: 3));
            store.Dispatch(actionCreators.Update(2, "APPLE"));
            store.Dispatch(actionCreators.Delete(id: 2));
            store.Dispatch(actionCreators.Delete(id: 1));

            Console.ReadKey();
        }
    }
}
