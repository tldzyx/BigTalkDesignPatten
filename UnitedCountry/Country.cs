namespace UnitedCountry
{
    internal abstract class Country
    {
        protected Country(UnitedNations mediator)
        {
            Mediator = mediator;
        }

        protected UnitedNations Mediator { get; }
    }
}