public class GameStats
{
    static string MakingHiddenWord(string input, char symbol)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                charArray[i] = symbol;
            }
        }
        return new string (charArray);
    }
}