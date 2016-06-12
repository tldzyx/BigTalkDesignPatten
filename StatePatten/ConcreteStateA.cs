namespace StatePatten
{
    internal class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            // 设置ConcreteStateA的下一状态是ConcreteStateB
            context.State = new ConcreteStateB();
        }
    }
}