/*/
Розробіть додаток, який знаходитиме мінімальне та максимальне значення у двовимірному масиві.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Input rows:");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input columns:");
        int columns = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[rows, columns];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 100);
            }
            
        }
        Console.WriteLine("Array:");
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        int min = array[0, 0];
        int max = array[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                if(array[i, j] < min)
                {
                    min = array[i, j];
                }
                if(array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
        
    }
}