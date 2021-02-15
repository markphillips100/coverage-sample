namespace HelloWorld
{
    public class Greeter
    {
        public string SayHello()
        {
            // The static call below is generated at build time, and will list the syntax trees used in the compilation
            return HelloWorldGenerated.HelloWorld.SayHello();
        }
    }
}
