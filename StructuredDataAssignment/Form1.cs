namespace StructuredDataAssignment;

public partial class Form1 : Form
{
    // Question 1: Public array of Vehicle with size 3
    public Vehicle[] vehicles = new Vehicle[3];
    
    // Question 2: Public array of Person with size 3
    public Person[] people = new Person[3];
    
    // Question 3: Public array of Pet with size 3
    public Pet[] pets = new Pet[3];
    
    // Question 4: Private array of SmartPhone with size 3
    private SmartPhone[] smartPhones = new SmartPhone[3];
    
    public Form1()
    {
        InitializeComponent();
    }
    
    // Question 1: Initialize Vehicle array with 3 vehicles
    private void btnMakeVehicles_Click(object sender, EventArgs e)
    {
        vehicles[0] = new Vehicle
        {
            Make = "Toyota",
            Model = "Camry",
            Year = 2018,
            Color = "Blue",
            LicensePlate = "ABC123"
        };
        
        vehicles[1] = new Vehicle
        {
            Make = "Dodge",
            Model = "Ram 3500",
            Year = 2019,
            Color = "Red",
            LicensePlate = "DEF456"
        };
        
        vehicles[2] = new Vehicle
        {
            Make = "Tesla",
            Model = "Cybertruck",
            Year = 2025,
            Color = "Space Metal",
            LicensePlate = "GHI789"
        };
    }
    
    // Question 2: Initialize Person array with 3 people
    private void btnMakePeople_Click(object sender, EventArgs e)
    {
        people[0] = new Person
        {
            FirstName = "Hal",
            LastName = "Finney",
            Age = DateTime.Now.Year - 1956, // Calculate age from birthdate
            Address = "1234 Bit St",
            PhoneNumber = "555-1234"
        };
        
        people[1] = new Person
        {
            FirstName = "Nick",
            LastName = "Szabo",
            Age = DateTime.Now.Year - 1964, // Calculate age from birthdate
            Address = "5678 Block St",
            PhoneNumber = "555-5678"
        };
        
        people[2] = new Person
        {
            FirstName = "Wei",
            LastName = "Dai",
            Age = DateTime.Now.Year - 1975, // Calculate age from birthdate
            Address = "91011 Chain St",
            PhoneNumber = "555-91011"
        };
    }
    
    // Question 3: Initialize Pet array with 3 pets
    private void btnMakePets_Click(object sender, EventArgs e)
    {
        pets[0] = new Pet
        {
            Name = "Fido",
            Species = "Dog",
            DateOfBirth = new DateTime(2010, 1, 1),
            Owner = "Alex"
        };
        
        pets[1] = new Pet
        {
            Name = "Whiskers",
            Species = "Cat",
            DateOfBirth = new DateTime(2015, 5, 5),
            Owner = "Bob"
        };
        
        pets[2] = new Pet
        {
            Name = "Bubbles",
            Species = "Fish",
            DateOfBirth = new DateTime(2020, 12, 12),
            Owner = "Charlie"
        };
    }
    
    // Question 4: Initialize SmartPhone array with 3 smartphones
    private void btnMakeSmartPhones_Click(object sender, EventArgs e)
    {
        smartPhones[0] = new SmartPhone
        {
            Manufacturer = "Foxconn",
            Model = "iPhone 12",
            OperatingSystem = "iOS",
            Color = "Black",
            PhoneNumber = "555-1212"
        };
        
        smartPhones[1] = new SmartPhone
        {
            Manufacturer = "Samsung",
            Model = "Galaxy S24",
            OperatingSystem = "Android",
            Color = "White",
            PhoneNumber = "555-2424"
        };
        
        smartPhones[2] = new SmartPhone
        {
            Manufacturer = "Google",
            Model = "Pixel 6",
            OperatingSystem = "Android",
            Color = "Green",
            PhoneNumber = "555-6666"
        };
    }
}
