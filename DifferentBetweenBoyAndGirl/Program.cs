using System;

namespace DifferentBetweenBoyAndGirl
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ObjectStructure structure = new ObjectStructure();
            structure.Attach(new Man());
            structure.Attach(new Woman());

            Action v1 = new Sucess();
            structure.Display(v1);

            Action v2 = new Failing();
            structure.Display(v2);

            Action v3 = new Amativeness();
            structure.Display(v3);

            Action v4 = new Marriage();
            structure.Display(v4);

            Console.ReadKey(true);
        }
    }
}