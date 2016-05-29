namespace FineryShow
{
    public class Finery : Person
    {
        protected Person Component { get; set; }

        /// <summary>
        ///     打扮
        /// </summary>
        public void Decorate(Person component)
        {
            Component = component;
        }

        public override void Show()
        {
            Component?.Show();
        }
    }
}