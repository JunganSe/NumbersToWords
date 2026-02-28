Console.Write("Enter numbers: ");
string? input = Console.ReadLine();

if (NumbersToWords.InputChecker.IsDigits(input))
{
    var wordMaker = new NumbersToWords.Wordmaker();
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