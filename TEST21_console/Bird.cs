using System;
using System.Collections.Generic;
using System.Text;

namespace TEST21_console
{
    public partial class Bird
    {
        private string Name;

        public Bird()
        {
            Console.WriteLine("Bird constructor. Name={0} ",Name);
        }
        public void SetName(string input)
        {
            this.Name = input;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
