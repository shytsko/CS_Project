// Your job is to create a calculator which evaluates expressions in Reverse Polish notation.
// For example expression 5 1 2 + 4 * + 3 - (which is equivalent to 5 + ((1 + 2) * 4) - 3 in normal notation) should evaluate to 14.
// For your convenience, the input is formatted such that a space is provided between every token.
// Empty expression should evaluate to 0.
// Valid operations are +, -, *, /.
// You may assume that there won't be exceptional situations (like stack underflow or division by zero).
using System;
using System.Collections.Generic;

Console.WriteLine(evaluate("1 3 +"));
Console.WriteLine(evaluate("1 3 *"));
Console.WriteLine(evaluate("1 3 -"));
Console.WriteLine(evaluate("4 2 /"));
Console.WriteLine(evaluate("5 1 2 + 4 * + 3 -"));
Console.WriteLine(evaluate("3"));
Console.WriteLine(evaluate("3,5"));
Console.WriteLine(evaluate(""));

double evaluate(String expr)
{
    String[]  RPNStrings = expr.Split(' ');
    Array.Reverse(RPNStrings);
    Stack<String> RPNStack = new Stack<String>(RPNStrings);
    Stack<double> operands = new Stack<double>();

    while(RPNStack.Count > 0)
    {
        String str = RPNStack.Pop();
        double operand2 = 0;
        double operand1 = 0;
        if(double.TryParse(str, out operand1))
            operands.Push(operand1);
        else if(str == String.Empty)
            operands.Push(0.0);
        else
        {
            operand2 = operands.Pop();
            operand1 = operands.Pop();
            switch(str)
            {
                case "+": operand1 += operand2; break;
                case "-": operand1 -= operand2; break;
                case "*": operand1 *= operand2; break;
                case "/": operand1 /= operand2; break;
                default: break;  //exception - not valid expression 
            }
            operands.Push(operand1);
        }

    }
    
    if(operands.Count == 1)
        return operands.Pop();
    else
        return 0.0;
}