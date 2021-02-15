using HelloWorld;
using System;

namespace GeneratedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run the various scenarios
            Console.WriteLine("Running HelloWorld:\n");

            // Using generated code
            var greeter = new HelloWorld.Greeter();
            Console.WriteLine(greeter.SayHello());

            // Using non-generated code
            var greeter2 = new HelloWorld2.Greeter();
            Console.WriteLine(greeter2.SayHello());

        }
    }
}
