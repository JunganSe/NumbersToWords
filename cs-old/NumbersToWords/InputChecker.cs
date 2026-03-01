namespace NumbersToWords;

public class InputChecker
{
    public static bool IsDigits(string? input)
    {
        return !string.IsNullOrEmpty(input)
            && input.All(char.IsDigit);
    }

    public static bool IsT9(string? input)
    {
        string validCharacters = "23456789";
        return !string.IsNullOrEmpty(input)
            && input.All(c => validCharacters.Contains(c));
    }
}
