using DefaultInterfaceMembers.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DefaultInterfaceMembers.Widgets
{
    public class CatWidget : IAnimalWidget
    {
        public string Name => "Cat";

        public int Happiness { get; set; }
    }
}
