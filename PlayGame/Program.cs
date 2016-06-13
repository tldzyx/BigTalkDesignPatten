using System;

namespace PlayGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GameRole lixiaoyao = new GameRole();

            // 大战BOSS前
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            // 保存进度
            RoleStateCaretaker caretaker = new RoleStateCaretaker();
            caretaker.Memento = lixiaoyao.SaveState();


            // 大战BOSS时，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            // 恢复之前状态
            lixiaoyao.RecoveryState(caretaker.Memento);
            lixiaoyao.StateDisplay();

            Console.ReadKey(true);
        }
    }
}