using CardGame.ClassLibrary;

namespace CardGame.CommandLineApp;

internal class Program
{
    static void Main(string[] args)
    {
        Card card1 = new Card(Suits.Hearts, 3);
        Card card2 = new Card(Suits.Spades, 10);
        Card card3 = new Card(Suits.Clubs, 2);
        Card card4 = new Card(Suits.Diamonds, 8);
        Card card5 = new Card(Suits.Hearts, 6);
        Card card6 = new Card(Suits.Spades, 1);
        Card card7 = new Card(Suits.Clubs, 4);

        Hand hand = new Hand(new List<Card> { card1, card2, card3, card4, card5, card6, card7 });

        foreach (var card in hand.GetAllCards())
        {
            Console.WriteLine(card.ToString());
        }
        Console.WriteLine();

        Card newCard = new Card(Suits.Diamonds, 9);
        hand.AddCard(newCard);

        foreach (var card in hand.GetAllCards())
        {
            Console.WriteLine(card.ToString());
        }

        Console.WriteLine();

        hand[4] = new Card(Suits.Clubs, 13);
        Console.WriteLine(hand[4]);

        Console.WriteLine();

        foreach (var card in hand.GetAllCards())
        {
            Console.WriteLine(card.ToString());
        }
    }
}
