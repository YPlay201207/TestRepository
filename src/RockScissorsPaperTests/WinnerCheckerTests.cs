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
        const int lizard = 4; 
        const int spoke = 5;
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

        [Fact]
        public void FirstScissorsSecondPaper()
        {
            int correct = 1;
            int result = winnerChecker.WinnerChecker2(scissors, paper);
            Assert.Equal(correct, result);
        }

        //--------------------------------------------------------------------

        [Fact]
        public void FirstSpokeSecondLizard()
        {
            int correct = 2;
            int result = winnerChecker.WinnerChecker3(spoke, lizard);
            Assert.Equal(correct, result);
        }

        [Fact]
        public void FirstLizsrdSecondSpoke()
        {
            int correct = 1;
            int result = winnerChecker.WinnerChecker3(lizard, spoke);
            Assert.Equal(correct, result);
        }
    }
}
