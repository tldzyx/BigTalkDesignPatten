using System;

namespace MusicExpression
{
    // 表达式类
    internal abstract class Expression
    {
        // 解释器
        public void Interpret(PlayContext context)
        {
            if (string.IsNullOrWhiteSpace(context.PlayText))
            {
                return;
            }

            var playKey = context.PlayText.Substring(0, 1);
            context.PlayText = context.PlayText.Substring(2);
            var playValue =
                Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ", StringComparison.Ordinal)));
            context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" ", StringComparison.Ordinal) + 1);

            Excute(playKey, playValue);
        }

        // 执行
        public abstract void Excute(string playKey, double playValue);
    }
}