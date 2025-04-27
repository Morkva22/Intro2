/*/
Користувач вводить із клавіатури речення. Додаток має порахувати кількість голосних літер у реченні.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Input a sentence: ");
        string sentence = Console.ReadLine();
        int vowelCount = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        foreach (char c in sentence)
        {
            if (Array.Exists(vowels, element => element == c))
            {
                vowelCount++;
            }
        }
        Console.WriteLine($"The number of vowels in the sentence is: {vowelCount}");
        
    }
}