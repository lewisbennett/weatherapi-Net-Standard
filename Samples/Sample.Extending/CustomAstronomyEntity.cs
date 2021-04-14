using System;
using WeatherAPI.Entities;

namespace Sample.Extending
{
    public class CustomAstronomyEntity : AstronomyResponseEntity
    {
        private readonly string _message = "I'm a message from a custom entity!";

        /// <summary>
        /// Does something custom.
        /// </summary>
        public void DoSomethingCustom()
        {
            Console.WriteLine(_message);
        }
    }
}
