using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace warGame
{
    public class NumOfCards 
    {
        private int player;
        private int comp;

        public NumOfCards()
        {
            player = 0;
            comp = 0;
        }

        public NumOfCards(int p, int c)
        {
            player = p;
            comp = c;
        }

        public void setPlayerCards(int num)
        {
            player = num;
        }

        public void setCompCards(int num)
        {
            comp = num;
        }

        public int getPlayerCards()
        {
            return player;
        }

        public int getCompCards()
        {
            return comp;
        }


       
    }
}
