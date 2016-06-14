using System.Collections.Generic;

namespace DifferentBetweenBoyAndGirl
{
    internal class ObjectStructure
    {
        private readonly IList<Person> _elements = new List<Person>();

        public void Attach(Person element)
        {
            _elements.Add(element);
        }

        public void Detach(Person element)
        {
            _elements.Remove(element);
        }

        public void Display(Action visitor)
        {
            foreach (Person element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}