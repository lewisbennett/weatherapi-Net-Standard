using System;
using WeatherAPI.NET.Entities;

namespace Sample.Extending
{
    public class CustomAstronomyResponseEntity : AstronomyResponseEntity
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
