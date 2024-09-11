using System.Threading.Channels;
using System.Windows.Markup;

namespace CardGame.ClassLibrary;

public enum Suits { Hearts, Clubs, Spades, Diamonds}
public class Card
{
    public Suits Suit { get; set; }
    public int Value { get; set; }

    public Card(Suits suit, int value)
    {
        Suit = suit;
        Value = value;
    }

    public int CompareTo(Card other)
    {
        return Value.CompareTo(other.Value);
    }

    public override string ToString()
    {
        return $"{Value} of {Suit}";
    }

}
