using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool pc = false;
            foreach (char znak in text)
                if (Char.IsDigit(znak))
                {
                    pc = true;
                    break;
                }

            if (pc)
                Console.WriteLine("I'm not calculator");
            else if (text.Equals("Date"))
                Console.WriteLine(System.DateTime.Now.ToString());
            else
                Console.WriteLine("Hi!");
            Console.ReadKey();
        }
    }
}
