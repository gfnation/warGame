using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace warGame
{
    /*
    class Shuffle
    {
        public bool oneUsed, twoUsed, threeUsed, fourUsed, fiveUsed, sixUsed, sevenUsed, eightUsed, nineUsed, tenUsed, elevenUsed, tweleveUsed,
            thirteenUsed, fourteenUsed, fifteenUsed, sixteenUsed, seventeenUsed, eighteenUsed, nineteenUsed, twentyUsed, twentyoneUsed,
            twentytwoUsed, twentythreeUsed, twentyfourUsed, twentyfiveUsed, twentysixUsed, twentyeightUsed, twentynineUsed, thirtyUsed,
            thirtyoneUsed, thirtytwoUsed, thirtythreeUsed, thirtyfourUsed, thirtyfiveUsed, thirtysixUsed, thirtysevenUsed, thirtynineUsed,
            fortyUsed, fortyoneUsed, fortytwoUsed, fortythreeUsed, fortyfourUsed, fortyfiveUsed, fortysixUsed, fortysevenUsed, fortyeightUsed,
            fortynineUsed, fortyeightUsed, fortynineUsed, fiftyUsed, fiftyoneUsed, fiftytwoUsed;
        
        
        
        public void mix(){
            while (oneUsed == false && twoUsed && threeUsed && fourUsed && fiveUsed && sixUsed && sevenUsed && eightUsed && nineUsed && tenUsed && elevenUsed && tweleveUsed &&
               thirteenUsed && fourteenUsed && fifteenUsed && sixteenUsed && seventeenUsed && eighteenUsed && nineteenUsed && twentyUsed && twentyoneUsed &&
               twentytwoUsed && twentythreeUsed && twentyfourUsed && twentyfiveUsed && twentysixUsed && twentyeightUsed && twentynineUsed && thirtyUsed &&
               thirtyoneUsed && thirtytwoUsed && thirtythreeUsed && thirtyfourUsed && thirtyfiveUsed && thirtysixUsed && thirtysevenUsed && thirtynineUsed &&
               fortyUsed && fortyoneUsed && fortytwoUsed && fortythreeUsed && fortyfourUsed && fortyfiveUsed && fortysixUsed && fortysevenUsed && fortyeightUsed &&
               fortynineUsed && fiftyUsed && fiftyoneUsed && fiftytwoUsed)
            {
                Random mixture = new Random();

            }

            }
    }
}*/

    public class Shuffle
    {
        private int[] shuffle = new int[52];
        protected int[] playerDeck;
        protected int[] compDeck;
        private int[] newDeck = new int[52];
        private int[] usedNums = new int[52];

        Random r = new Random();
        public Shuffle(int[] fullDeck)
        {
            int cnt = 0;
            int a = 0;
            while(cnt<52)
            {
                
                a = r.Next(52);
                usedNums[a] = a;
                for(int c=0; c<52; c++)
                {
                    if (a != usedNums[c] && c == 51)
                    {
                        a = newDeck[cnt];
                        cnt= cnt +1;
                    }

                }
                
                
            }

        }                    
                 


    }

}
