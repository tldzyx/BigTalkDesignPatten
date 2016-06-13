namespace AdapterPatten
{
    internal class Adapter : Target
    {
        private readonly Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}