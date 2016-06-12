using System.Drawing;

namespace PersonBuilder
{
    internal class PersonThinBuilder : PersonBuilder
    {
        private readonly Graphics _graphics;
        private readonly Pen _pen;

        public PersonThinBuilder(Graphics graphics, Pen pen)
        {
            _graphics = graphics;
            _pen = pen;
        }

        public override void BuildHead()
        {
            // 头
            _graphics.DrawEllipse(_pen, 50, 20, 30, 30);
        }

        public override void BuildBody()
        {
            // 身体
            _graphics.DrawRectangle(_pen, 60, 50, 10, 50);
        }

        public override void BuildArmLeft()
        {
            // 左手
            _graphics.DrawLine(_pen, 60, 50, 40, 100);
        }

        public override void BuildArmRight()
        {
            // 右手
            _graphics.DrawLine(_pen, 70, 50, 90, 100);
        }

        public override void BuildLegLeft()
        {
            // 左脚
            _graphics.DrawLine(_pen, 60, 100, 45, 150);
        }

        public override void BuildLegRight()
        {
            // 右脚
            _graphics.DrawLine(_pen, 70, 100, 85, 150);
        }
    }
}