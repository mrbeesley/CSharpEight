using DefaultInterfaceMembers.Contracts;
using DefaultInterfaceMembers.Widgets;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfaceMembers
{
    public class AnimalWidgetProgram
    {
        public static void Start(string[] args)
        {
            IAnimalWidget.SetAmountToFeed(15);

            var dog = new DogWidget();
            var cat = new CatWidget();
            var hamster = new HamsterWidget();

            var animals = new IAnimalWidget[] { dog, cat, hamster };

            foreach (var animal in animals)
            {
                animal.Feed();
                Console.WriteLine($"Happiness level for {animal.Name}: {animal.Happiness}");
            }
        }
    }
}
