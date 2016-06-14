namespace DifferentBetweenBoyAndGirl
{
    internal abstract class Person
    {
        // 它是用来获得“状态”对象的
        public abstract void Accept(Action visitor);
    }
}