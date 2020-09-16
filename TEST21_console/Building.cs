using System;
using System.Collections.Generic;
using System.Text;

namespace TEST21_console
{
    public sealed class Building:Blueprint      //no one can further inherit
    {
        public override void Description()      //obligated definition as per capability class
        {
            //throw new NotImplementedException();    
            Console.WriteLine("Building Description() called.");
        }
    }
}
