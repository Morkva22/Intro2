/*/
Створіть додаток, який відображає кількість парних, непарних, унікальних елементів масиву.
/*/

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input array length:");
        int length = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 100);
        }
        Console.WriteLine("Array: " + string.Join(", ", array));

        var result = AnalyzeArray(array);
        Console.WriteLine("Couples numbers: " + result.couples);
        Console.WriteLine("Odd numbers: " + result.odd);
        Console.WriteLine("Unique values: " + result.unique);
    }

    public static (int couples, int odd, int unique) AnalyzeArray(int[] array)
    {
        int couples = 0;
        int odd = 0;
        int unique = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
                couples++;
            else
                odd++;
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            bool isUnique = false;
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j && array[i] == array[j])
                {
                    isUnique = true;
                    break;
                }
            }
            if (isUnique)
                unique++;
        }

        return (couples, odd, unique);
    }
}