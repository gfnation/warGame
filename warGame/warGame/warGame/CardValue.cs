using System;

namespace warGame
{
    public class CardValue
    {
        private int value;
        public CardValue(int card)
        {
            if (card >= 0 && card < 4)
                value = 1;
            else if (card >= 4 && card < 8)
                value = 2;
            else if (card >= 8 && card < 12)
                value = 3;
            else if (card >= 12 && card < 16)
                value = 4;
            else if (card >= 16 && card < 20)
                value = 5;
            else if (card >= 20 && card < 24)
                value = 6;
            else if (card >= 24 && card < 28)
                value = 7;
            else if (card >= 28 && card < 32)
                value = 8;
            else if (card >= 32 && card < 36)
                value = 9;
            else if (card >= 36 && card < 40)
                value = 10;
            else if (card >= 40 && card < 44)
                value = 11;
            else if (card >= 44 && card < 48)
                value = 12;
            else
                value = 13;

        }

        public int getValue()
        {
            return value;
        }
    }
}