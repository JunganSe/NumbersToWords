namespace NumbersToWords;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string? input = Console.ReadLine();

        if (InputChecker.IsDigits(input))
        {
            var wordMaker = new Wordmaker();
            var combinations = wordMaker.GetCombinations(input!, wordMaker.KeyT9EnglishExtended);

            foreach (var item in combinations)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(combinations.Count + " combinations");
        }
        else
        {
            Console.WriteLine("Not T9.");
        }
    }
}