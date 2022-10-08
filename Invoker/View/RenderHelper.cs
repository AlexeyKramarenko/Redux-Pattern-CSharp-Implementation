using Redux.Storage;
using Invoker.Entities;
using System;
using System.Text;

namespace Invoker.View
{
    static class RenderHelper
    {
        internal static void DisplayState(State state)
        {
            var stateDescription = new StringBuilder("State: ");

            state.ForEach(entity =>
            {
                if (entity is Phone)
                {
                    var phone = entity as Phone;

                    stateDescription.Append($" Phone: {{ ID: {phone.Id}, Name: {phone.Name} }} ");
                }
            });

            Console.WriteLine(stateDescription);
        }
    }
}
