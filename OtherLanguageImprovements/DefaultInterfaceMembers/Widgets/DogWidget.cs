using DefaultInterfaceMembers.Contracts;
using System;

namespace DefaultInterfaceMembers.Widgets
{
    public class DogWidget : IAnimalWidget
    {
        public string Name => "Dog";

        public int Happiness { get; set; }

        public void Feed()
        {
            Happiness = int.MaxValue;
        }
    }
}
