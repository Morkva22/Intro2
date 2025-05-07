/*/
Користувач з клавіатури вводить у рядок арифметичний вираз.
Додаток має порахувати його результат. Необхідно підтримувати тільки дві операції: + і -
/*/

using System;

public class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input arithmetic expression (only + and -):");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        try
        {
            int result = EvaluateExpression(input);
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static int EvaluateExpression(string expression)
    {
        string[] tokens = expression.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
        int result = 0;
        int index = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (char.IsDigit(expression[i]))
            {
                if (index < tokens.Length)
                {
                    int number = int.Parse(tokens[index]);
                    if (i == 0 || expression[i - 1] == '+')
                    {
                        result += number;
                    }
                    else if (expression[i - 1] == '-')
                    {
                        result -= number;
                    }
                    index++;
                }
            }
        }

        return result;
    }
}