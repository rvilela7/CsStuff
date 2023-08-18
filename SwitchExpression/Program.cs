using System;

namespace SwitchExpression
{
    public class Program
    {
        public enum Operator
        {
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE
        }

        public class Calculator
        {
            public string GetOperatorText(Operator op) => op switch
                {
                    Operator.ADD => "Add",
                    Operator.SUBTRACT => "Subtract",
                    Operator.MULTIPLY => "Multiply",
                    Operator.DIVIDE => "Divide",
                    _ => "No text.",
                };
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine(new Calculator().GetOperatorText(Operator.ADD));
        }
    }
}