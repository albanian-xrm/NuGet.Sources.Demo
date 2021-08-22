using System;

namespace AlbanianXrm.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following are messages from dependencies:");
            var buildGreeter = new Build.BuildGreeter();
            Console.WriteLine(buildGreeter.Greet());
            var sourceGreeter = new Source.SourceGreeter();
            Console.WriteLine(sourceGreeter.Greet());

            Console.WriteLine("Press ANY key to continue...");
            Console.ReadKey();
        }
    }
}
