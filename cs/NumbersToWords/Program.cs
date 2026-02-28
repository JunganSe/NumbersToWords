namespace NumbersToWords;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string? input = Console.ReadLine();

        if (!InputChecker.IsDigits(input))
        {
            Console.WriteLine("Not T9 compatible.");
            return;
        }

        var wordMaker = new Wordmaker();
        var combinations = wordMaker.GetCombinations(input!, wordMaker.KeyT9EnglishExtended);

        Console.WriteLine(string.Join("\n", combinations));
        Console.WriteLine(combinations.Count + " combinations");
    }
}