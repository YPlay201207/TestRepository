using System;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {

        //1 - Rock, 2 - Paper, 3 - Scissors
        int answer = 1;
        public int WinnerChecker2(int FirstPlayer, int SecondPlayer){
            answer = 1;
            int a = FirstPlayer + 1;
            if(a == 4){
                a = 1;
            }
            if(a == SecondPlayer){
                answer = 2;
            }
            return answer;
        }   

    }
}
