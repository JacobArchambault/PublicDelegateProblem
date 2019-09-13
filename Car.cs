using System;
using System.Collections.Generic;
using System.Text;

namespace PublicDelegateProblem
{
    public class Car
    {
        public delegate void CarEngineHandler(string msgForCaller);

        // Now a public member!
        public CarEngineHandler listOfHandlers;

        // Just fire out the Exploded notification.
        public void Accelerate(int delta)
        {
            listOfHandlers?.Invoke("Sorry, this car is dead...");
        }

    }
}
