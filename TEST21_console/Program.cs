using System;
using System.IO;

namespace TEST21_console
{
    public partial class Bird
    {
        public void Speak()     //class method - work in progress
        {
            Console.WriteLine("Bird Speak");
        }
    }
    class Program
    {
        static void Doodah()
        {
            Console.WriteLine("Doodah called");
        }
        public static void WriteFile()
        {
            string raw = "aaaa,bbbb,cccc,dddd";
            string[] arr = raw.Split(',');

            foreach (string str2 in arr)
            {
                Console.WriteLine(str2);
            }
            string path = "C:\\Users\\wlee0\\source\\repos\\TEST21_console\\xxx.txt";
            try
            {
                using (StreamWriter w = new StreamWriter(path))
                {
                    int i = 0;
                    foreach (string s in arr)
                    {
                        w.WriteLine("array [" + ++i + "] " + s);
                    }
                }
            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        static void Main(string[] args)
        {
            string str;
            Console.Title = "TEST21_console";
            Console.WriteLine("Hello World!\r\nEnter a number...\r");

            str = Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(str);
                Console.WriteLine("input is a number..." + str);
            }
            catch(Exception err)
            {
                Console.WriteLine("input is NOT A NUMBER..." + str 
                    + "\r\n" + err.Message);
            }

            WriteFile();
            Doodah();

            Bird myBird = new Bird();       //constructor
            myBird.SetName("Tweedy");
            Console.WriteLine(myBird.GetName());
            myBird.Speak();

            Chicken myChicken = new Chicken();      //constructor
            myChicken.Speak();
            ((Bird)myChicken).Speak();  //unhide the base class method

            Building mybuilding = new Building();
            Capability_User user = new Capability_User();
            user.Describe(mybuilding);
        }

    }
}
