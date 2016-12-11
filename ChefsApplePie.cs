using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplePieCooking
{
    class ChefsApplePie : IApplePie //Jonagold Apples, Marek's ShortBread and Monika's Crumble
    {

        public ChefsApplePie()
        {
            Console.WriteLine("Stworzylem fabryke ChefsApplePie!");
        }

        public IShortBread createShortBread()
        {
            return new MareksShortBread();
        }

        public ICrumble createCrumble()
        {
            return new MonikasCrumble();
        }

        public IAppleMass createAppleMass()
        {
            return new JonagoldAppleMass();
        }


    }
}
