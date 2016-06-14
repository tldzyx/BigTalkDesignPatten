namespace VisitorPatten
{
    internal class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OpetationA()
        {
            
        }
    }
}