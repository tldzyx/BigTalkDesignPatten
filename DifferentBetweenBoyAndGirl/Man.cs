namespace DifferentBetweenBoyAndGirl
{
    internal class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}