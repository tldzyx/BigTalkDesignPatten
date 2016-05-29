using System;

namespace FineryShow
{
    public class Person
    {
        private readonly string _name;

        public Person()
            : this("无名氏")
        {
            
        }

        public Person(string name)
        {
            _name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"装扮的{_name}");
        }
    }
}