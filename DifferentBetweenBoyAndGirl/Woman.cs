namespace DifferentBetweenBoyAndGirl
{
    internal class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}