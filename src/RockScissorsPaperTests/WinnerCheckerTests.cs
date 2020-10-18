using System.Reflection;
using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
        WinnerChecker winnerChecker = new WinnerChecker();
        const int rock = 1;
        const int paper = 2; 
        const int scissors = 3;
        [Fact]
        public void BothPlayersChooseScissors()
        {
            var correct = 0;
            int result = winnerChecker.WinnerChecker2(scissors, scissors);
            Assert.Equal(correct, result);
        }

        [Fact]
        public void FirstSetRockSecondPaper(){
            var correct = 2;
            int result = winnerChecker.WinnerChecker2(rock, paper);
            Assert.Equal(correct, result);
        }
        int SomeWeird1 = 0;
        int SomeWeird2 = 6;
        [Fact]
        public void AtLeastOneOfThePlayersWriteSomeWeirdThing()
        {
            int correct = -1;
            int result = winnerChecker.WinnerChecker2(SomeWeird1, SomeWeird2);
            Assert.Equal(correct, result);
        }
    }
}
