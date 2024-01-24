public static class GameStats
{
    private static string[] letters;
    public static int lives = 6;

    static GameStats()
    {
        letters = new string[26];
    }

    public static string MakeHiddenWord(string input, char symbol)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                charArray[i] = symbol;
            }
        }

        return new string(charArray);
    }

    public static void UsedLetters(string item)
    {
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == item)
            {
                return;
            }
        }
    }
    public static void Lives()
    {
        lives--;
        System.Console.WriteLine("You have " + lives + " lives left.");
    }

    public static int GetLives()
    {
        return lives;
    }
}