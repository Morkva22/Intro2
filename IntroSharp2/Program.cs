/*/
Дано двовимірний масив розмірністю 5×5, заповнений випадковими числами з діапазону від -100 до 100. 
Визначити суму елементів масиву, розташованих між мінімальним і максимальним елементами.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        int rows = 5;
        int cols = 5;
        int[,] array = new int[rows, cols];
        Random random = new Random();
        int minValue = -100;
        int maxValue = 100;
        for(int i =0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(minValue, maxValue);
            }
        }
        Console.WriteLine("array: ");
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        int min = array[0, 0];
        int max = array[0, 0];
        int minIndex = 0;
        int maxIndex = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if(array[i, j] < min)
                {
                    min = array[i, j];
                    minIndex = i * cols + j;
                }
                if(array[i, j] > max)
                {
                    max = array[i, j];
                    maxIndex = i * cols + j;
                }
            }
        }
        Console.WriteLine("min: " + min);
        Console.WriteLine("max: " + max);
        Console.WriteLine("minIndex: " + minIndex);
        
    }
}