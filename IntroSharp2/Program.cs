/*/
Користувач вводить рядок із клавіатури. 
Необхідно зашифрувати цей рядок, використовуючи шифр Цезаря. З Вікіпедії: "Шифр Цезаря - це різновид шифру підстановки, 
в якому кожен символ у відкритому тексті замінюється символом, 
що знаходиться на деякому постійному числі позицій лівіше або правіше за нього в алфавіті. 
Наприклад, у шифрі зі зсувом вправо на 3, A була б замінена на D, B стане E, і так далі". Докладніше тут.
Крім механізму шифрування, реалізуйте механізм розшифрування.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
            Console.WriteLine("Enter the string to encrypt:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the shift value (positive for right, negative for left):");
            int shift = int.Parse(Console.ReadLine());

            string encrypted = Encrypt(input, shift);
            Console.WriteLine("Encrypted string: " + encrypted);

            string decrypted = Decrypt(encrypted, shift);
            Console.WriteLine("Decrypted string: " + decrypted);
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
        public static string Decrypt(string text, int shift)
        {
            return Encrypt(text, -shift);
        }
    }