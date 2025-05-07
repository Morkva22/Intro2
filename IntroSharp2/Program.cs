/*/
Оголосити одновимірний (5 елементів) масив з іменем A і двовимірний масив (3 рядки, 4 стовпці) дробових чисел з іменем B. 
Заповнити одновимірний масив А числами, введеними з клавіатури користувачем, 
а двовимірний масив В випадковими числами за допомогою циклів. 
Вивести на екран значення масивів: масиву А в один рядок, масиву В — у вигляді матриці. 
Знайти в даних масивах загальний максимальний елемент, мінімальний елемент, загальну суму всіх елементів, 
загальний добуток усіх елементів, суму парних елементів масиву А, суму непарних стовпців масиву В.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        
        int [] A = new int [5];
        double [,] B = new double [3, 4];
        Random random = new Random();
        Console.WriteLine("Input 5 numbers to array A: ");
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array B: ");
        for (int i = 0; i < B.GetLength(0); i++)
        {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble() * 100;
                    Console.Write(B[i, j] + " ");
                }
        }
        
        Console.WriteLine("\nArray A: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
        double max = A[0];
        double min = A[0];
        double sum = 0;
        double product = 1;
        double sumEven = 0;
        double sumOdd = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            }
            if (A[i] < min)
            {
                min = A[i];
            }
            sum += A[i];
            product *= A[i];
            if (A[i] % 2 == 0)
            {
                sumEven += A[i];
            }
        }
        for (int i = 0; i < B.GetLength(0); i++)
        {
            for (int j = 0; j < B.GetLength(1); j++)
            {
                if (B[i, j] > max)
                {
                    max = B[i, j];
                }
                if (B[i, j] < min)
                {
                    min = B[i, j];
                }
                sum += B[i, j];
                product *= B[i, j];
                if (j % 2 != 0)
                {
                    sumOdd += B[i, j];
                }
            }
        }
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Sum of even elements in A: " + sumEven);
        Console.WriteLine("Sum of odd columns in B: " + sumOdd);
            
            
            
            
        
    }
}