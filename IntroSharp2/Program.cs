/*/
Створіть додаток, який відображає кількість значень у масиві, менших за заданий користувачем параметр. 
Наприклад, кількість значень менших, ніж 7 (7 введено користувачем з клавіатури).
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Input array size");
        int size = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
        }
        Console.WriteLine("Input number");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] < number)
            {
                count++;
            }
        }
        Console.WriteLine("Array: " + string.Join(", ", array));
        Console.WriteLine("Count of numbers less than " + number + ": " + count);
        
    }
}