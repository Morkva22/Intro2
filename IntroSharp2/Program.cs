/*/
Дано 2 масиви розмірності M і N відповідно.
Необхідно переписати до третього масиву загальні елементи перших двох масивів без повторень.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 3, 4, 5, 6, 7 };
        int[] array3 = new int[array.Length + array2.Length];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array[i] == array2[j])
                {
                    bool exists = false;
                    for (int k = 0; k < index; k++)
                    {
                        if (array3[k] == array[i])
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        array3[index] = array[i];
                        index++;
                    }
                }
            }
        }
        Console.WriteLine("Array 1:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("\nArray 2:");
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i] + " ");
        }
        Console.WriteLine("\nArray 3:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(array3[i] + " ");
        }
        
    }
}