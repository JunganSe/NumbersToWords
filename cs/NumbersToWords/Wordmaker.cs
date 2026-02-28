namespace NumbersToWords;

public class Wordmaker
{
    public List<string> KeyT9English { get; }
    public List<string> KeyT9EnglishExtended { get; }
    public List<string> KeyT9Swedish { get; }
    public List<string> KeyT9SwedishExtended { get; }

    public Wordmaker()
    {
        KeyT9English = new List<string>() // Standard T9
        {
            "",     // 0
            "",     // 1
            "ABC",  // 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNO",  // 6
            "PQRS", // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };
        KeyT9EnglishExtended = new List<string>() // T9 där 1=2 och 0=9
        {
            "WXYZ", // 0
            "ABC",  // 1
            "ABC",  // 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNO",  // 6
            "PQRS", // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };
        KeyT9Swedish = new List<string>() // Standard T9
        {
            "",     // 0
            "",     // 1
            "ABCÅÄ",// 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNOÖ", // 6
            "PQRS", // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };
        KeyT9SwedishExtended = new List<string>() // T9 där 1=2 och 0=9
        {
            "WXYZ", // 0
            "ABCÅÄ",// 1
            "ABCÅÄ",// 2
            "DEF",  // 3
            "GHI",  // 4
            "JKL",  // 5
            "MNOÖ", // 6
            "PQRS", // 7
            "TUV",  // 8
            "WXYZ"  // 9
        };
    }

    public List<string> GetCombinations(string input, List<string> key) // V6. Tar valfritt antal tecken men blir trögt över 13.
    {
        List<int> digits = new();
        foreach (char c in input)
            digits.Add(int.Parse(c.ToString()));

        List<int> choices = new();
        foreach (var d in digits)
            choices.Add(key[d].Length);

        int length = digits.Count;
        int[] i = new int[length];
        string[] letters = new string[length];
        List<string> combinations = new();

        int digit = 0;
        for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
        {
            letters[digit] = key[digits[digit]][i[digit]].ToString();
            AddLetter();
        }
        return combinations;

        void AddLetter() // Körs rekursivt.
        {
            if (digit + 1 < length)
            {
                digit++;
                for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
                {
                    letters[digit] = letters[digit - 1] + key[digits[digit]][i[digit]].ToString();
                    AddLetter();
                }
                digit--;
            }
            else
                combinations.Add(letters[digit]);
        }
    }



    ////////////////////////
    public List<string> GetCombinationsV5(string input, List<string> key) // V5. Tar valfritt antal tecken men blir trögt över 13.
    {
        List<int> digits = new();
        foreach (char c in input)
            digits.Add(int.Parse(c.ToString()));

        List<int> choices = new();
        foreach (var d in digits)
            choices.Add(key[d].Length);

        int length = digits.Count;
        int[] i = new int[length];
        string[] letters = new string[length];
        List<string> combinations = new();

        int digit = 0;
        for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
        {
            letters[digit] = key[digits[digit]][i[digit]].ToString();

            if (digit + 1 < length)
            {
                AddLetter();
            }
            else
                combinations.Add(letters[digit]);
        }
        return combinations;

        void AddLetter()
        {
            digit++;
            for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
            {
                letters[digit] = letters[digit - 1] + key[digits[digit]][i[digit]].ToString();
                if (digit + 1 < length)
                {
                    AddLetter();
                }
                else
                    combinations.Add(letters[digit]);
            }
            digit--;
        }
    }

    public List<string> GetCombinationsV4(string input, List<string> key) // V4. Tar 1-3 tecken.
    {
        List<int> digits = new();
        foreach (char c in input)
            digits.Add(int.Parse(c.ToString()));

        List<int> choices = new();
        foreach (var d in digits)
            choices.Add(key[d].Length);

        int length = digits.Count;
        int[] i = new int[length];
        string[] letters = new string[length];
        List<string> combinations = new();

        int digit = 0;
        for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
        {
            letters[digit] = key[digits[digit]][i[digit]].ToString();

            if (digit + 1 < length)
            {
                digit++;
                for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
                {
                    letters[digit] = letters[digit - 1] + key[digits[digit]][i[digit]].ToString();

                    if (digit + 1 < length)
                    {
                        digit++;
                        for (i[digit] = 0; i[digit] < choices[digit]; i[digit]++)
                        {
                            letters[digit] = letters[digit - 1] + key[digits[digit]][i[digit]].ToString();

                            if (digit + 1 < length)
                            {
                                // nästa loop
                            }
                            else
                                combinations.Add(letters[digit]);
                        }
                        digit--;
                    }
                    else
                        combinations.Add(letters[digit]);
                }
                digit--;
            }
            else
                combinations.Add(letters[digit]);
        }

        return combinations;
    }

    public List<string> GetCombinationsV3(string input, List<string> key) // V3. Tar 1-3 tecken.
    {
        List<int> digits = new();
        foreach (char c in input)
            digits.Add(int.Parse(c.ToString()));

        List<int> choices = new();
        foreach (var digit in digits)
            choices.Add(key[digit].Length);

        int length = digits.Count;
        int[] i = new int[length];
        string[] letters = new string[length];
        List<string> combinations = new();

        for (i[0] = 0; i[0] < choices[0]; i[0]++)
        {
            letters[0] = key[digits[0]][i[0]].ToString();

            if (0 < length - 1)
            {
                for (i[1] = 0; i[1] < choices[1]; i[1]++)
                {
                    letters[1] = letters[0] + key[digits[1]][i[1]].ToString();

                    if (1 < length - 1)
                    {
                        for (i[2] = 0; i[2] < choices[2]; i[2]++)
                        {
                            letters[2] = letters[1] + key[digits[2]][i[2]].ToString();

                            if (2 < length - 1)
                            { } // nästa loop
                            else
                                combinations.Add(letters[2]);
                        }
                    }
                    else
                        combinations.Add(letters[1]);
                }
            }
            else
                combinations.Add(letters[0]);
        }

        return combinations;
    }

    public List<string> GetCombinationsV2(string input, List<string> key) // V2. Tar enbart 3 tecken.
    {
        List<int> digits = new();
        foreach (char c in input)
            digits.Add(int.Parse(c.ToString()));

        List<int> choices = new();
        foreach (var digit in digits)
            choices.Add(key[digit].Length);

        string[] letters = new string[digits.Count];
        List<string> combinations = new();

        for (int a = 0; a < choices[0]; a++)
        {
            letters[0] = key[digits[0]][a].ToString();

            for (int b = 0; b < choices[1]; b++)
            {
                letters[1] = letters[0] + key[digits[1]][b].ToString();

                for (int c = 0; c < choices[2]; c++)
                {
                    letters[2] = letters[1] + key[digits[2]][c].ToString();

                    combinations.Add(letters[2]);
                }
            }
        }

        return combinations;
    }

    public List<string> GetCombinationsV1(string input, List<string> key) // V1. Tar enbart 3 tecken.
    {
        List<int> digits = new();
        foreach (char c in input)
            digits.Add(int.Parse(c.ToString()));

        List<int> choices = new();
        foreach (var digit in digits)
            choices.Add(key[digit].Length);

        List<string> combinations = new();
        for (int a = 0; a < choices[0]; a++)
        {
            string combination1 = key[digits[0]][a].ToString();

            for (int b = 0; b < choices[1]; b++)
            {
                string combination2 = combination1 + key[digits[1]][b].ToString();

                for (int c = 0; c < choices[2]; c++)
                {
                    string combination3 = combination2 + key[digits[2]][c].ToString();

                    combinations.Add(combination3);
                }
            }
        }

        return combinations;
    }
}
