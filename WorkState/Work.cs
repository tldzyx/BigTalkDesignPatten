namespace WorkState
{
    internal class Work
    {
        public Work()
        {
            // 工作初始化为上午工作状态，即上午9点开始上班
            State = new ForenoonState();
        }

        // “钟点”属性，状态转换的依据
        public double Hour { get; set; }

        // “任务完成”属性，是否能下班的依据
        public bool TaskFinished { get; set; }

        public State State { get; set; }

        public void WriteProgram()
        {
            State.WriteProgram(this);
        }

        public void SetState(State state)
        {
            State = state;
        }
    }
}