﻿class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("This is a random word guessing game. ");
        System.Console.WriteLine("The goal of this game is to guess the random word before running out of lives.");
        System.Console.WriteLine("You have 6 lives. You will input a single letter at a time.");
        System.Console.WriteLine("The game will then tell you if the word has any of that letter in it.");
        System.Console.WriteLine("If the word does have some of that letter the game will reprint out the word \nwith the unguessed blanks and the correct letters in the word. ");
        System.Console.WriteLine("And that covers it. Very complicated I know. All I have left to say is good luck.");
        
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