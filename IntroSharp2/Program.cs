/*/
Напишіть програму, яка приймає через командний рядок текст і відображає частотний аналіз —
скільки разів кожен символ зустрічається в тексті.
Програма має враховувати як великі, так і малі літери окремо.
/*/

class Program
{
    static void Main(string[] args)
    {

        string inputText = args[0];
        Console.WriteLine("Analyzing text: " + inputText);
        Console.WriteLine("Character frequency analysis:");
        
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();
        
        foreach (char currentChar in inputText)
        {
            if (frequencyMap.ContainsKey(currentChar))
            {
                frequencyMap[currentChar]++;
            }
            else
            {
                frequencyMap.Add(currentChar, 1);
            }
        }
        
        foreach (KeyValuePair<char, int> entry in frequencyMap)
        {
            Console.WriteLine($"Character '{entry.Key}': {entry.Value} occurrences");
        }
        
        Console.WriteLine($"\nTotal characters analyzed: {inputText.Length}");
    }
}