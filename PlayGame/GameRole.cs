using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGame
{
    class GameRole
    {
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense { get; set; }

        /// <summary>
        /// 状态显示
        /// </summary>
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine($"体力：{Vitality}");
            Console.WriteLine($"攻击力：{Attack}");
            Console.WriteLine($"防御力：{Defense}");
            Console.WriteLine();
        }

        /// <summary>
        /// 获得初始状态
        /// </summary>
        public void GetInitState()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;
        }

        /// <summary>
        /// 战斗
        /// </summary>
        public void Fight()
        {
            Vitality = 0;
            Attack = 0;
            Defense = 0;
        }

        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vitality, Attack, Defense);
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            Vitality = memento.Vitality;
            Attack = memento.Attack;
            Defense = memento.Defense;
        }
    }
}
