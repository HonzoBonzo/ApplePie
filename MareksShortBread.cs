using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplePieCooking
{
    class MareksShortBread : IShortBread
    {
        public MareksShortBread()
        {
            Console.WriteLine("Tworze MareksShortBread");
        }
        public void showMe()
        {
            Console.WriteLine("MareksShortBread");
        }
    }
}
