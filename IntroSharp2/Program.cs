/*/
Користувач вводить речення з клавіатури. Вам необхідно підрахувати кількість слів у ньому.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Write a sentence:");
        string sentence = Console.ReadLine();
        int Words = 0;
        bool space = false;
        foreach (char c in sentence)
        {
            if (char.IsWhiteSpace(c))
            {
                if (space)
                {
                    Words++;
                    space = false;
                }
            }
            else
            {
                space = true;
            }
        }
        if (space)
        {
            Words++;
        }
        Console.WriteLine($"The number of words in the sentence is: {Words}");
        
    }
}