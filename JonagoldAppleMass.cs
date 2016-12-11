using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplePieCooking
{
    class JonagoldAppleMass : IAppleMass
    {
        public JonagoldAppleMass()
        {
            Console.WriteLine("Tworze JonagoldAppleMass");
        }
        public void showMe()
        {
            Console.WriteLine("JonagoldAppleMass");
        }
    }
}
