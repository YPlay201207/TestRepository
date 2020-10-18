using System;

namespace RockScissorsPaperLib
{
    public class WinnerChecker
    {
        //1 - Rock, 2 - Paper, 3 - Scissors, 4 - Lizard, 5 - Spoke 
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
        public int WinnerChecker3(int FirstPlayer, int SecondPlayer)
        {
            switch (FirstPlayer)
            {
                case 1:
                    if (SecondPlayer == 3 || SecondPlayer == 4) return 1;
                    else if (SecondPlayer == 1) return 0;
                    else return 2;
                case 2:
                    if (SecondPlayer == 1 || SecondPlayer == 5) return 1;
                    else if (SecondPlayer == 2) return 0;
                    else return 2;
                case 3:
                    if (SecondPlayer == 2 || SecondPlayer == 4) return 1;
                    else if (SecondPlayer == 3) return 0;
                    else return 2;
                case 4: 
                    if (SecondPlayer == 2 || SecondPlayer == 5) return 1;
                    else if (SecondPlayer == 4) return 0;
                    else return 2;
                case 5: 
                    if (SecondPlayer == 1 || SecondPlayer == 3) return 1;
                    else if (SecondPlayer == 5) return 0;
                    else return 2;
                default:
                    return -1;
            }
        }
    }
}
