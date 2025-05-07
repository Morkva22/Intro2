/*/
Користувач з клавіатури вводить деякий текст.
Додаток повинен змінювати регістр першої літери кожного речення на букву у верхньому регістрі.
/*/

using System.Globalization;

public class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your text:");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty.");
            return;
        }

        string result = CapitalizeSentences(input);
        Console.WriteLine("Result:");
        Console.WriteLine(result);
    }

    public static string CapitalizeSentences(string text)
    {
        string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < sentences.Length; i++)
        {
            string trimmed = sentences[i].Trim();
            if (trimmed.Length > 0)
            {
                sentences[i] = char.ToUpper(trimmed[0], CultureInfo.InvariantCulture) + trimmed.Substring(1);
            }
        }

        return string.Join(". ", sentences).Trim() + (text.EndsWith(".") ? "." : "");
    }
}