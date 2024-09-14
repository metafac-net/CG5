﻿namespace MetaFac.CG5.Expressions
{
    public partial record BinaryExpressionNode : Node
    {
        public static BinaryExpressionNode Create(BinaryOperator op, Node left, Node right) => new BinaryExpressionNode() { Left = left, Op = op, Right = right };

        public override string ToString()
        {
            return Op switch
            {
                BinaryOperator.Assign => $"({Left} := {Right})",
                _ => $"({Left} {Op} {Right})"
            };
        }
    }
}
