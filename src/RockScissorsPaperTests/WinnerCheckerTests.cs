using System;
using Xunit;
using RockScissorsPaperLib;

namespace RockScissorsPaperTests
{
    public class WinnerCheckerTests
    {
        const int rock = 1;
        const int paper = 2; 
        const int scissors = 3;
        [Fact]
        public void BothPlayersChooseScissors()
        {
            WinnerChecker winnerChecker = new WinnerChecker();
            var correct = 0;
            int result = winnerChecker.WinnerChecker2(scissors, scissors);
            Assert.Equal(correct, result);

        }
    }
}
