class Program
{
    public static void Main(string[] args)
    {
        //hi
        string super " supercalifragilisticexpialidocious";
        string odd "odd";
        string ob "obfuscate";
        string ind "indistinguishableness";
        string hipo "hippopotomonstrosesquippedaliophobia";
        string me "methylchloroisothiazolinone";
        string gir "giraffa camelopardalis";
        string guy "guy on a buffalo";
        string buff "buffet";
        string moo "moose";

        int randomWord = random.Next(10);

        string selectedString = (randomWord == 0) ? super : (randomWord == 1) ? odd : (randomWord == 2) ? ob : (randomWord == 3) ? ind : (randomWord == 4) ? hipo : (randomWord == 5) ? me : (randomWord == 6) ? gir : (randomWord == 7) ? guy : (randomWord == 8) ? buff : moo;

        string hiddenWord = selectedString.Replace(' ', '_');
        string changeLetters = MakeHiddenWord(originalText, '*');

        Console.WriteLine(selectedString);

    }
}