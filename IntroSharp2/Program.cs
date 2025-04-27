/*/
Користувач вводить із клавіатури три числа. 
Необхідно підрахувати скільки разів послідовність із цих трьох чисел зустрічається в масиві.
/*/

public class Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the third number:");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 1, 2, 3 };
        int count = 0;
        for (int i = 0; i < array.Length - 2; i++)
        {
            if (array[i] == firstNumber && array[i + 1] == secondNumber && array[i + 2] == thirdNumber)
            {
                count++;
            }
        }
        Console.WriteLine("The array is: ");
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine($"        The sequence {firstNumber}, {secondNumber}, {thirdNumber} occurs {count} times in the array.");
        
        
    }
}