using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ClassLibrary;

public class Hand
{
    private List<Card> Cards;

    public Hand(List<Card> cards)
    {
        Cards = cards;
    }

    public Card this[int index]
    {
        get
        {
            if (index < 0 || index >= Cards.Count)
            {
                throw new IndexOutOfRangeException("Out of range");
            }
            return Cards[index];
        }
        set
        {
            if (index < 0 || index >= Cards.Count)
            {
                throw new IndexOutOfRangeException("Out of range");
            }
            Cards[index] = value;
        }
    }

    public void AddCard(Card card)
    {
        if (Cards.Count == 7)
        {
            Card lowestCard = Cards.OrderBy(c => c.Value).First();
            RemoveCard(lowestCard);
        }
        Cards.Add(card);
    }

    public void ClearCard(Card card)
    {
        Cards.Clear();
    }

    public IEnumerable<Card> GetAllCards()
    {
        return Cards;
    }

    public Card GetCardAtIndex(int index)
    {
        return Cards[index];
    }

    public void RemoveCard(Card card)
    {

        Cards.Remove(card);
    }

    public void RemoveCardAtIndex(int index)
    {
        Cards.RemoveAt(index);
    }
}
