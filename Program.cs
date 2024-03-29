﻿class Program
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
        string eph = "ephemeral";
        string le = "lethologica";
        string qui = "quixotic";
        string mel = "mellifluous";
        string per = "perspicacious";
        string yet = "yowie";
        string pl = "plait";
        string zi = "zibet";
        string qu = "quash";
        string fyt = "fytte";

        int randomWord = random.Next(20);

        string selectedString = (randomWord == 0) ? super : (randomWord == 1) ? odd : (randomWord == 2) ? ob : (randomWord == 3) ? ind : (randomWord == 4) ? hipo : (randomWord == 5) ? me : (randomWord == 6) ? gir : (randomWord == 7) ? guy : (randomWord == 8) ? buff : (randomWord == 9) ? moo : (randomWord == 10) ? eph : (randomWord == 11) ? le : (randomWord == 12) ? qui : (randomWord == 13) ? mel : (randomWord == 14) ? per : (randomWord == 15) ? yet : (randomWord == 16) ? pl : (randomWord == 17) ? zi : (randomWord == 18) ? qui : fyt;

        string hiddenWord = GameStats.MakeHiddenWord(selectedString, '*');

        Console.WriteLine($"Your word: {hiddenWord}");


        switch (randomWord)
        {
            case 0:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 1:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 2:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 3:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 4:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 5:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 6:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 7:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 8:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 9:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 10:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 11:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 12:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 13:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 14:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 15:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 16:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 17:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 18:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
            case 19:
                while (hiddenWord.Contains('*') && GameStats.GetLives() > 0)
                {
                    Console.WriteLine("Guess a letter");
                    Console.WriteLine($"Your guessed letters: {string.Join(", ", GameStats.GetLetters())}");
                    string guess = Console.ReadLine();

                    bool guessedLetter = false;

                    if (!GameStats.GetLetters().Contains(guess))
                    {
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
                        Console.Clear();

                        if (guessedLetter)
                        {
                            Console.WriteLine(hiddenWord);
                        }

                        GameStats.AddLetters(guess);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You already guessed this letter. Guess again.");
                    }
                    if (!guessedLetter)
                    {
                        Console.WriteLine("That letter is not in this word. You lost a life.");
                        GameStats.Lives();
                        Console.WriteLine(hiddenWord);
                    }
                }
                break;
        }
        if (GameStats.GetLives() > 0)
        {
            Console.WriteLine("Congradulations you won!!!!!!!!!!!");
        }
        else
        {
            Console.WriteLine("You lost LOL. (sad face).");
            Console.WriteLine($"This was your word: {selectedString}");
        }
    }
}