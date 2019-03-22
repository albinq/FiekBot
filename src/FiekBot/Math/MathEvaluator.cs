﻿using NCalc;

namespace FiekBot.Math
{
    public class MathEvaluator : IExpressionEvaluator
    {
        public string Evaluate(string expression)
        {
            var expr = new Expression(expression);
            return expr.Evaluate().ToString();
        }
    }
}
