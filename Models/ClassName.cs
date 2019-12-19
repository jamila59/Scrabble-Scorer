using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Models
{
  public class Scrabble
  {
   public static Dictionary  <char, int> letters = new Dictionary<char , int>(){

        {'A',1},{'B',4},{'C',4}, {'D',2}, {'E',1},{'F',4}, {'G',3}, {'H',3}, {'I',1}, {'J',10}, {'K',5},{'L',2},  {'M',4}, {'N',2}, {'O',1}, {'P',4}, {'Q',10},{'R',1}, {'S',1}, {'T',1}, {'U',2}, {'V',5}, {'W',4},{'X',8}, {'Y',3}, {'Z', 10} };

      public string Input { get; set ;}
  
      public Scrabble(string input)
      {
        Input = input;
      }

     public int GetScore(string input)
      {
          int totalPoints = 0;
          string inputUpper = input.ToUpper();
          for (int i = 0; i < inputUpper.Length; i++)
          {
            if(letters.ContainsKey(inputUpper[i]))
            {
              totalPoints += letters[inputUpper[i]];
              Console.ForegroundColor = ConsoleColor.Cyan;
            }
          }
          Console.WriteLine("Your Score:" + "" + totalPoints);
          return totalPoints; 
        }
    }
}
  
 
  








   