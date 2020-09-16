using System;
using System.Collections.Generic;
using System.Text;

namespace TEST21_console
{
    class Chicken:Bird
    {
        public Chicken()
        {
            Console.WriteLine("Chicken constructor. ");
        }

        public new void Speak()
        {
            Console.WriteLine("Chicken new Speak");
        }

    }
}
