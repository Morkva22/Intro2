/*/
Реалізуйте програму, яка приймає через командний рядок: рядок для шифрування та ключ зсуву.
Використовуючи шифр Цезаря, зашифруйте рядок і виведіть результат.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: <string to encrypt> <shift key>");
            return;
        }

        string input = args[0];
        if (!int.TryParse(args[1], out int shift))
        {
            Console.WriteLine("The shift key must be an integer.");
            return;
        }

        string encrypted = Encrypt(input, shift);
        Console.WriteLine("Encrypted string: " + encrypted);
    }

    public static string Encrypt(string text, int shift)
    {
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];
            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)(((letter + shift - offset) % 26 + 26) % 26 + offset);
            }
            buffer[i] = letter;
        }
        return new string(buffer);
    }
}