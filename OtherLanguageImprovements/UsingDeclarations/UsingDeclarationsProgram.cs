using System;

namespace UsingDeclarations
{
    public class UsingDeclarationsProgram
    {
        public static void Start(string[] args)
        {
            using var resource = new DisposableResource();

            Console.WriteLine($"Using resource: {resource.Value}");
            Console.WriteLine("All Finished!");
        }
    }
}
