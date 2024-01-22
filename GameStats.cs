public static class GameStats
{
    private string[] letters;
    letters = new string[24];
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
        return new string (charArray);
    }
    public void UsedLetters(string word)
    {
        for (int i = 0; i < letters.length; i++)
        {
            if (letters[i] = item;)
            {
                return;
            }
        }
    }
}