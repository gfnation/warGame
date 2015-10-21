using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace warGame
{
    public class Shuffle
    {
        public NumOfCards n = new NumOfCards(26,26);

        protected int[] playerDeck;
        protected int[] compDeck;
        private int[] newDeck = new int[52];
        
        Random r = new Random();
        public Shuffle(int[] fullDeck)
        {
            playerDeck = new int[n.getPlayerCards()];
            compDeck = new int[n.getCompCards()];
            int cnt = 0;
            int a = 0;
            while(cnt<51)
            {
                
                a = r.Next(52);
                for(int c=0; c< 52; c++)
                {
                    if (a == newDeck[c])
                        break;
                    if (a != newDeck[c] && c == 51)
                    {
                        newDeck[cnt]=a;
                        cnt++;
                    }

                }
                
                
                
            }

        }

        public int[] getPlayerDeck()
        {
            int cnt = 0;
            int temp;
            for (int p = 0; p < 26; p++)
            {
                temp = newDeck[cnt];
                playerDeck[p] = temp;
                cnt = cnt + 2;
            }

            return playerDeck;
        }

        public int[] getCompDeck()
        {
            int cnt = 1;
            for (int c = 0; c < 26; c++)
            {
                compDeck[c] = newDeck[cnt];
                cnt = cnt + 2;
            }
            return compDeck;
        }

                 


    }

}
