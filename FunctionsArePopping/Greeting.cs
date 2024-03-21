using System;

namespace Greeting
{
    public static class GreetingMessage
    {
        public static void Greet(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }
    }
}