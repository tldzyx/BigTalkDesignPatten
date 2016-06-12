namespace StatePatten
{
    internal class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            // 设置ConcreteStateB的下一状态是ConcreteStateA
            context.State = new ConcreteStateA();
        }
    }
}