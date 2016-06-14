using System;
using System.Collections.Generic;

namespace InterpreterPatten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Context context = new Context();

            IList<AbstractExpression> expressions = new List<AbstractExpression>();
            expressions.Add(new TerminalExpression());
            expressions.Add(new NonterminalExpression());
            expressions.Add(new TerminalExpression());
            expressions.Add(new TerminalExpression());

            foreach (AbstractExpression expression in expressions)
            {
                expression.Interpret(context);
            }

            Console.ReadKey(true);
        }
    }
}