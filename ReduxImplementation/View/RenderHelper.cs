using Redux.Storage;
using ReduxImplementation.Entities;
using System;
using System.Text;

namespace ReduxImplementation.View
{
    static class RenderHelper
    {
        internal static void DisplayStateOnEveryDispatchedAction(State state)
        {
            var stateDescription = new StringBuilder("State: ");
            state.ForEach(entity =>
            {
                var phone = entity as Phone;
                stateDescription.Append($" Phone: {{ ID: {phone.Id}, Name: {phone.Text} }} ");
            });

            Console.WriteLine(stateDescription);
        }
    }
}
