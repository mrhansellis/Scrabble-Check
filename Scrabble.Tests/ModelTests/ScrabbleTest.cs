using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

namespace Scrabble.Test
{
  [TestClass]
  public class ScoreCardTests
  {
    /*[TestMethod]
    public void ScoreCardConstructor_CreatesInstanceOfScoreCard_ScoreCard()
    {
      ScoreCard newScoreCard = new ScoreCard("test");
      Assert.AreEqual(typeof(ScoreCard), newScoreCard.GetType());
    }
    [TestMethod]
    public void GetEntry_ReturnsEntry_String()
    {
      string entry = "hans";
      ScoreCard newScoreCard = new ScoreCard(entry);
      string result = newScoreCard.Entry;
      Assert.AreEqual(entry, result);
    }
    [TestMethod]
    public void SetEntry_SetEntry_String()
    {
      string entry = "hans";
      ScoreCard newScoreCard = new ScoreCard(entry);
      string newEntry = "conundrum";
      newScoreCard.Entry = newEntry;
      string result = newScoreCard.Entry;
      Assert.AreEqual(newEntry, result);
    }*/
    [TestMethod]
    public void SplitEntry_SplitEntry_Array()
    {
      string entry = "hans";
      ScoreCard newScoreCard = new ScoreCard();
      //string[] result = newScoreCard.SplitEntry;
      Assert.AreEqual(7, newScoreCard.ScoreCounter(entry));
    }
  }
}
