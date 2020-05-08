using System;
using System.Collections.Generic;
using System.Text;

namespace UsingDeclarations
{
    public class DisposableResource : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Disposable Resource: Disposing!");
        }

        public string Value => "disposable-resource";
    }
}
