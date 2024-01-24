public class GameStats
{
    private static string[] letters = new string[26];
    public static int lives = 6;

    public static void AddLetters(string item)
    {
        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] == null)
            {
                letters[i] = item;
                break;
            }
        }
    }

    public static string[] GetLetters()
    {
        return letters.Where(letters => letters != null).ToArray() ?? Array.Empty<string>();
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