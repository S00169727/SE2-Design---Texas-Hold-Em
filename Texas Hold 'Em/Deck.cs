using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Hold__Em
{
    class Deck: List<Card>
    {
        public Deck()
        {
            this.Reset();
        }

        public bool IsEmpty()
        {
            if (this.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Shuffle()
        {
            List<Card> tempList = new List<Card>();

            Card tempCard;

            Random r = new Random();

            while (this.Count > 0)
            {
                tempCard = this[r.Next(this.Count)];
                tempList.Add(tempCard);
                this.Remove(tempCard);
            }
        }

        public void Reset()
        {
            Card c;

            this.Clear();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    c = new Card((NumberValue)j, (CardSuits)i);
                    this.Add(c);
                }
            }
        }
    }
}
