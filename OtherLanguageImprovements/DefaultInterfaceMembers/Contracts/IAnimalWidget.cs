using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfaceMembers.Contracts
{
    public interface IAnimalWidget
    {
        private static int AmountToFeed = 10;

        static void SetAmountToFeed(int amount)
        {
            AmountToFeed = amount;
        }

        string Name { get; }
        int Happiness { get; set; }
        void Feed()
        {
            Happiness += AmountToFeed;
        }
    }
}
