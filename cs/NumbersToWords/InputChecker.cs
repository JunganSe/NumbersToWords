namespace NumbersToWords
{
    public class InputChecker
    {
        public static bool IsDigits(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public static bool IsT9(string? input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string validCharacters = "23456789";
            foreach (char c in input)
            {
                if (!validCharacters.Contains(c))
                    return false;
            }

            return true;
        }
    }
}
