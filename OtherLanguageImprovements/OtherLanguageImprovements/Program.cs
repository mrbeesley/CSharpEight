using DefaultInterfaceMembers;
using UsingDeclarations;
using AsyncStreams;
using StaticLocalDemo;
using System;

namespace OtherLanguageImprovements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Animal Widgets Example:");
            Console.WriteLine("######################################");

            AnimalWidgetProgram.Start(args);

            Console.WriteLine("######################################");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Starting Using Declarations Example:");
            Console.WriteLine("######################################");

            UsingDeclarationsProgram.Start(args);

            Console.WriteLine("######################################");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Starting Async Streams Example:");
            Console.WriteLine("######################################");

            AsyncStreamsProgram.StartAsync(args).Wait();

            Console.WriteLine("######################################");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Starting Local Static Example:");
            Console.WriteLine("######################################");

            StaticLocalDemoProgram.Start(args);

            Console.WriteLine("######################################");
        }
    }
}
