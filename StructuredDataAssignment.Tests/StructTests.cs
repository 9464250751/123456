namespace StructuredDataAssignment.Tests;

public class StructTests
{
    [Fact]
    public void Vehicle_ShouldHaveCorrectFields()
    {
        // Arrange & Act
        Vehicle vehicle = new Vehicle
        {
            Make = "Toyota",
            Model = "Camry",
            Year = 2018,
            Color = "Blue",
            LicensePlate = "ABC123"
        };

        // Assert
        Assert.Equal("Toyota", vehicle.Make);
        Assert.Equal("Camry", vehicle.Model);
        Assert.Equal(2018, vehicle.Year);
        Assert.Equal("Blue", vehicle.Color);
        Assert.Equal("ABC123", vehicle.LicensePlate);
    }

    [Fact]
    public void Person_ShouldHaveCorrectFields()
    {
        // Arrange & Act
        Person person = new Person
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30,
            Address = "123 Main St",
            PhoneNumber = "555-1234"
        };

        // Assert
        Assert.Equal("John", person.FirstName);
        Assert.Equal("Doe", person.LastName);
        Assert.Equal(30, person.Age);
        Assert.Equal("123 Main St", person.Address);
        Assert.Equal("555-1234", person.PhoneNumber);
    }

    [Fact]
    public void Pet_ShouldHaveCorrectFields()
    {
        // Arrange
        DateTime dateOfBirth = new DateTime(2020, 1, 1);

        // Act
        Pet pet = new Pet
        {
            Name = "Fido",
            Species = "Dog",
            DateOfBirth = dateOfBirth,
            Owner = "Alice"
        };

        // Assert
        Assert.Equal("Fido", pet.Name);
        Assert.Equal("Dog", pet.Species);
        Assert.Equal(dateOfBirth, pet.DateOfBirth);
        Assert.Equal("Alice", pet.Owner);
    }

    [Fact]
    public void SmartPhone_ShouldHaveCorrectFields()
    {
        // Arrange & Act
        SmartPhone phone = new SmartPhone
        {
            Manufacturer = "Apple",
            Model = "iPhone 12",
            OperatingSystem = "iOS",
            Color = "Black",
            PhoneNumber = "555-1212"
        };

        // Assert
        Assert.Equal("Apple", phone.Manufacturer);
        Assert.Equal("iPhone 12", phone.Model);
        Assert.Equal("iOS", phone.OperatingSystem);
        Assert.Equal("Black", phone.Color);
        Assert.Equal("555-1212", phone.PhoneNumber);
    }

    [Fact]
    public void PlayingCard_ShouldHaveCorrectFields()
    {
        // Arrange & Act
        PlayingCard card = new PlayingCard
        {
            Suit = "Hearts",
            Number = 5
        };

        // Assert
        Assert.Equal("Hearts", card.Suit);
        Assert.Equal(5, card.Number);
    }

    [Fact]
    public void DeckOfCards_ShouldInitializeWith52Cards()
    {
        // Arrange & Act
        DeckOfCards deck = new DeckOfCards();

        // Assert
        Assert.NotNull(deck.Cards);
        Assert.Equal(52, deck.Cards.Count);
    }

    [Fact]
    public void DeckOfCards_ShouldContainAllSuits()
    {
        // Arrange & Act
        DeckOfCards deck = new DeckOfCards();
        var suits = deck.Cards.Select(c => c.Suit).Distinct().ToList();

        // Assert
        Assert.Equal(4, suits.Count);
        Assert.Contains("Hearts", suits);
        Assert.Contains("Diamonds", suits);
        Assert.Contains("Clubs", suits);
        Assert.Contains("Spades", suits);
    }

    [Fact]
    public void DeckOfCards_ShouldContainAllNumbers()
    {
        // Arrange & Act
        DeckOfCards deck = new DeckOfCards();
        var numbers = deck.Cards.Select(c => c.Number).Distinct().ToList();

        // Assert
        Assert.Equal(13, numbers.Count);
        for (int i = 1; i <= 13; i++)
        {
            Assert.Contains(i, numbers);
        }
    }

    [Fact]
    public void DeckOfCards_Shuffle_ShouldChangeCardOrder()
    {
        // Arrange
        DeckOfCards deck1 = new DeckOfCards();
        DeckOfCards deck2 = new DeckOfCards();
        
        var originalOrder = deck1.Cards.ToList();

        // Act
        deck2.Shuffle();

        // Assert
        // After shuffling, at least some cards should be in different positions
        bool isDifferent = false;
        for (int i = 0; i < Math.Min(10, deck2.Cards.Count); i++)
        {
            if (deck2.Cards[i].Suit != originalOrder[i].Suit || 
                deck2.Cards[i].Number != originalOrder[i].Number)
            {
                isDifferent = true;
                break;
            }
        }
        Assert.True(isDifferent, "Shuffle should change the order of cards");
    }

    [Fact]
    public void DeckOfCards_Deal_ShouldReturnTopCard()
    {
        // Arrange
        DeckOfCards deck = new DeckOfCards();
        var firstCard = deck.Cards[0];
        int initialCount = deck.Cards.Count;

        // Act
        var dealtCard = deck.Deal();

        // Assert
        Assert.Equal(firstCard.Suit, dealtCard.Suit);
        Assert.Equal(firstCard.Number, dealtCard.Number);
        Assert.Equal(initialCount - 1, deck.Cards.Count);
    }

    [Fact]
    public void DeckOfCards_Deal_ShouldThrowWhenEmpty()
    {
        // Arrange
        DeckOfCards deck = new DeckOfCards();
        
        // Deal all cards
        while (deck.Cards.Count > 0)
        {
            deck.Deal();
        }

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => deck.Deal());
    }
}
