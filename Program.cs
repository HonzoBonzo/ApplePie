using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplePieCooking
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplePie fabrykaAbstrakcyjna = new ChefsApplePie();
            
            IAppleMass masa = fabrykaAbstrakcyjna.createAppleMass();
            ICrumble kruszonka = fabrykaAbstrakcyjna.createCrumble();
            IShortBread krucheCiasto = fabrykaAbstrakcyjna.createShortBread();

            masa.showMe();
            kruszonka.showMe();
            krucheCiasto.showMe();
            Console.ReadKey();
        }
    }
}
