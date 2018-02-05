using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Hold__Em
{
    public enum CardSuits { spades, hearts, diamonds, clubs }
    public enum NumberValue { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 }

    class Card
    {
        public NumberValue Rank { get; set; }
        public CardSuits Suit { get; set; }

        public Card(NumberValue r, CardSuits s)
        {
            Rank = r;
            Suit = s;
        }


        public override string ToString()
        {
            return string.Format($"{Enum.GetName(typeof(CardSuits),Suit)}, {Enum.GetName(typeof(NumberValue),Rank)}");
        }
    }
}
