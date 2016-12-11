using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplePieCooking
{
    class MonikasCrumble : ICrumble
    {
        public MonikasCrumble()
        {
            Console.WriteLine("Tworze MonikasCrumble");
        }
        public void showMe()
        {
            Console.WriteLine("MonikasCrumble");
        }
    }
}
