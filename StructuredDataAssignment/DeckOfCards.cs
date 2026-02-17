namespace StructuredDataAssignment;

public struct DeckOfCards
{
    public List<PlayingCard> Cards;

    public DeckOfCards()
    {
        Cards = new List<PlayingCard>();
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        
        // Create a standard deck of 52 cards (13 cards per suit)
        foreach (string suit in suits)
        {
            for (int number = 1; number <= 13; number++)
            {
                PlayingCard card = new PlayingCard
                {
                    Suit = suit,
                    Number = number
                };
                Cards.Add(card);
            }
        }
    }

    public void Shuffle()
    {
        Random random = new Random();
        // Shuffle by swapping random cards many times
        for (int i = 0; i < 1000; i++)
        {
            int index1 = random.Next(0, 52);
            int index2 = random.Next(0, 52);
            
            // Swap cards at index1 and index2
            PlayingCard temp = Cards[index1];
            Cards[index1] = Cards[index2];
            Cards[index2] = temp;
        }
    }

    public PlayingCard Deal()
    {
        if (Cards.Count == 0)
        {
            throw new InvalidOperationException("No cards left in the deck.");
        }
        
        // Deal from the top of the deck (first card)
        PlayingCard card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }
}
