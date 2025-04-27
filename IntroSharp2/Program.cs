/*/
Створіть додаток для підрахунку кількості входжень підрядка в рядок. 
Користувач вводить вихідний рядок і слово для пошуку. Додаток відображає результат пошуку.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Write the string:");
        string str = Console.ReadLine();
        Console.WriteLine("Write the word to find:");
        string word = Console.ReadLine();
        int count = 0;
        int index = str.IndexOf(word);
        while (index != -1)
        {
            count++;
            index = str.IndexOf(word, index + word.Length);
        }
        Console.WriteLine($"The word '{word}' appears {count} times in the string.");
        
    }
}