/*/
Напишіть програму, яка приймає розміри двовимірного масиву і число для множення через параметри командного рядка (наприклад, 3 3 2).
Програма повинна згенерувати випадковий двовимірний масив, помножити всі його елементи на задане число і вивести результат.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: <rows> <columns> <multiplier>");
            return;
        }

        if (!int.TryParse(args[0], out int rows) || !int.TryParse(args[1], out int columns) || !int.TryParse(args[2], out int multiplier))
        {
            Console.WriteLine("All arguments must be integers.");
            return;
        }

        int[,] matrix = GenerateRandomMatrix(rows, columns);
        Console.WriteLine("Generated Matrix:");
        PrintMatrix(matrix);

        int[,] multipliedMatrix = MultiplyMatrix(matrix, multiplier);
        Console.WriteLine("Matrix after multiplication:");
        PrintMatrix(multipliedMatrix);
    }

    public static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    public static int[,] MultiplyMatrix(int[,] matrix, int multiplier)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix[i, j] * multiplier;
            }
        }

        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}