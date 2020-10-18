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
            if(FirstPlayer == SecondPlayer){
                answer = 0;
            }
            if(FirstPlayer > 3 || FirstPlayer < 1 || SecondPlayer > 3 || SecondPlayer < 0){
                answer = -1;
            }
            return answer;
        }   
    }
}
