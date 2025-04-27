/*/
Користувач вводить речення з клавіатури.
 Вам необхідно перевернути кожне слово речення і відобразити результат на екран.
/*/

public class Programa
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Input a sentence:");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        string reversedSentence = "";
        foreach (string word in words)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            reversedSentence += new string(charArray) + " ";
        }

        Console.WriteLine("Reversed sentence:");
        Console.WriteLine(reversedSentence.Trim());
    }
}