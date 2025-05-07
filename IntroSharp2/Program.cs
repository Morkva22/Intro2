/*/
Створіть додаток, який виконує операції над матрицями:
Множення матриці на число;
Додавання матриць;
Добуток матриць.
/*/

class Program
{
    static void Main()
    {
        int[,] matrixA = { {1, 2}, {3, 4} };
        int[,] matrixB = { {5, 6}, {7, 8} };
        int number = 2;
        
        int[,] multipliedMatrix = MultiplyByNumber(matrixA, number);
        
        Console.WriteLine("MultiplyByNumber:");
        for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multipliedMatrix.GetLength(1); j++)
            {
                Console.Write(multipliedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        int[,] sumMatrix = AddMatrices(matrixA, matrixB);
        
        Console.WriteLine("\nAddMatrices:");
        for (int i = 0; i < sumMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < sumMatrix.GetLength(1); j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);
        
        Console.WriteLine("\nMultiplyMatrices:");
        for (int i = 0; i < productMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < productMatrix.GetLength(1); j++)
            {
                Console.Write(productMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyByNumber(int[,] matrix, int num)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix[i, j] * num;

        return result;
    }
    static int[,] AddMatrices(int[,] a, int[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }

    static int[,] MultiplyMatrices(int[,] a, int[,] b)
    {
        int rowsA = a.GetLength(0);
        int colsA = a.GetLength(1);
        int colsB = b.GetLength(1);
        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
            for (int j = 0; j < colsB; j++)
                for (int k = 0; k < colsA; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }
}