namespace MobileGame
{
    internal abstract class HandsetBrand
    {
        protected HandsetSoft Soft { get; private set; }

        public void SetHandsetSoft(HandsetSoft soft)
        {
            Soft = soft;
        }

        public abstract void Run();
    }
}