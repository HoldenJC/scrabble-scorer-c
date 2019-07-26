using System;
using System.Collections.Generic;

namespace Scrabble
{

  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Enter word for scrabble points calculation:");
      string userWord = Console.ReadLine();
      userWord = userWord.ToLower();
      int wordScore = 0;

      char[] wordOriginal = userWord.ToCharArray();
      
      for(int i = 0; i < userWord.Length; i++)
      {
        if(wordOriginal[i] == 'a' || wordOriginal[i] == 'e' || wordOriginal[i] == 'i' || wordOriginal[i] == 'o' || wordOriginal[i] == 'u' || wordOriginal[i] == 'l' || wordOriginal[i] == 'n' || wordOriginal[i] == 'r' || wordOriginal[i] == 's' || wordOriginal[i] == 't')
        {
          wordScore += 1;
        } else if(wordOriginal[i] == 'd' || wordOriginal[i] == 'g')
        {
          wordScore += 2;
        } else if(wordOriginal[i] == 'b' || wordOriginal[i] == 'c' || wordOriginal[i] == 'm' || wordOriginal[i] == 'p')
        {
          wordScore += 3;
        } else if(wordOriginal[i] == 'f' || wordOriginal[i] == 'h' || wordOriginal[i] == 'v' || wordOriginal[i] == 'w' || wordOriginal[i] == 'y')
        {
          wordScore += 4;
        } else if(wordOriginal[i] == 'k')
        {
          wordScore += 5;
        } else if (wordOriginal[i] == 'j' || wordOriginal[i] == 'x')
        {
          wordScore += 8;
        } else if (wordOriginal[i] == 'q' || wordOriginal[i] == 'z')
        {
          wordScore += 10;
        } else 
        {
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.WriteLine("Your word contains a non letter at index position " + i + ": " + wordOriginal[i]);
          Console.ResetColor();
        }
      }

      Console.WriteLine("The scrabble point value for the word '" + userWord +"' is " + wordScore + " points.");

    }

  }

}