class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("This is a random word guessing game. ");
        System.Console.WriteLine("The goal of this game is to guess the random word before running out of lives.");
        System.Console.WriteLine("You have 6 lives. You will input a single letter at a time.");
        System.Console.WriteLine("The game will then tell you if the word has any of that letter in it.");
        System.Console.WriteLine("If the word does have some of that letter the game will reprint out the word \nwith the unguessed letters as blanks and the correct letters filled in the word. ");
        System.Console.WriteLine("If there are multiple words there will be spaces in between the astericks.");
        System.Console.WriteLine("And that covers it. Very complicated I know. All I have left to say is good luck.");

        Random random = new Random();

        string super = "supercalifragilisticexpialidocious";
        string odd = "odd";
        string ob = "obfuscate";
        string ind = "indistinguishableness";
        string hipo = "hippopotomonstrosesquippedaliophobia";
        string me = "methylchloroisothiazolinone";
        string gir = "giraffa camelopardalis";
        string guy = "guy on a buffalo";
        string buff = "buffet";
        string moo = "moose";

        int randomWord = random.Next(0);

        string selectedString = (randomWord == 0) ? super : (randomWord == 1) ? odd : (randomWord == 2) ? ob : (randomWord == 3) ? ind : (randomWord == 4) ? hipo : (randomWord == 5) ? me : (randomWord == 6) ? gir : (randomWord == 7) ? guy : (randomWord == 8) ? buff : moo;

        string hiddenWord = GameStats.MakeHiddenWord(selectedString, '*');

        Console.WriteLine($"Your word: {hiddenWord}");


        switch (randomWord)
        {
            case 0:
                while (hiddenWord.Contains('*'))
                {
                    Console.WriteLine("Guess a letter");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    for (int i = 0; i < selectedString.Length; i++)
                    {
                        if (selectedString[i] == guess[0])
                        {
                            char[] charArray = hiddenWord.ToCharArray();
                            charArray[i] = guess[0];
                            hiddenWord = new string(charArray);
                            guessedLetter = true;
                        }
                    }
                    
                    if (guessedLetter)
                    {
                        Console.WriteLine(hiddenWord);
                    }
                    else
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                    }
                }
                break;
        }

    }
}