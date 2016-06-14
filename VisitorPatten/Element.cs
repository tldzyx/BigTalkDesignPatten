namespace VisitorPatten
{
    internal abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}