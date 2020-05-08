using DefaultInterfaceMembers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfaceMembers.Widgets
{
    public class HamsterWidget : IAnimalWidget
    {
        public string Name => "Hamster";

        public int Happiness { get; set; }
    }
}
