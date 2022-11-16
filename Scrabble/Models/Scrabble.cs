using System;

namespace Scrabble.Models
{
  public class ScoreCard
  {
    public string Entry { get; set; }

    
    public int ScoreCounter(string input)
    {
      //this sets the input to lowercase so that it can correctly be assesed
      input = input.ToLower();
      int score = 0;
      
      //these are the arrays of letters that have the same point value in scrabble
      string[] OnePoint = {"a", "e", "i", "o", "l", "n", "r", "s", "t"};
      string[] TwoPoint = {"d", "g"};
      string[] ThreePoint = {"b", "c", "m", "p"};
      string[] FourPoint = {"f", "h", "v", "w", "y"};
      string[] FivePoint = {"k"};
      string[] EightPoint = {"j", "x"};
      string[] TenPoint = {"q", "z"};

      //this is an array of all the other arrays
      string[][] AllPoints = {OnePoint, TwoPoint, ThreePoint, FourPoint, FivePoint, EightPoint, TenPoint};
      
      int[] points = {1, 2, 3, 4, 5, 8, 10};

      //For every array in allpoints, call scorer, and add its result to the score
      for(int i = 0; i < AllPoints.Length; i++)
      {
        score += Scorer(AllPoints[i], input, points[i]);
    }
        return score;
    }

    public int Scorer(string[] PointArray, string input, int x)
    {
      int LocalScore = 0;
//for every character in input, call Checkall. If Checkall returns true, then add however many points that letter is worth to local score. Then return localscore
      for(int i = 0; i < input.Length; i++)
      {
        if(CheckAll(PointArray, input[i]))
        {
          LocalScore += x;
        }
      }
    return LocalScore;
    }

        public bool CheckAll(string[] array, char input)
    {
      //for all the letters worth an amount of points, check to see if the character in input is equal to any of them. Return true if a match is found.
      for(int i = 0; i < array.Length; i++)
      {
        string CurrentChar = array[i];
        if(input == CurrentChar[0])
        {
          return true;
        }
      }
      return false;
    }
  }
}