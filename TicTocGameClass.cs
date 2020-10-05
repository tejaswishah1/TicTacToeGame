using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTocGameClass
    {
        

        public void CreateBoard()
        {
          
            char[] GameBoard = new char[10];

            for(int i=1; i<10; i++)
            {
                GameBoard[i] = ' ';
            }
            
        }
    }
}
