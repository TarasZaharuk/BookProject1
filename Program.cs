Book book = new Book("C# Book", "description", "Alex Shevchuk", new DateOnly(2024, 1, 7));
book.Description = ""; 

Console.WriteLine(book.Rating != null ? book.Rating : "there is no rating");
Console.WriteLine(book.GetInfo());
Console.WriteLine("Hello");
Console.ReadKey();
class Book
{
    private string _description;
    private int? _rating;
    public Book(string name, string description, string author, DateOnly dateOfPublishing)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new Exception("Name is empty");

        if (string.IsNullOrWhiteSpace(description))
            throw new Exception("Description is empty");

        if (string.IsNullOrWhiteSpace(author))
            throw new Exception("Author is empty");

        if (dateOfPublishing.Year < 1991 || dateOfPublishing.Year > DateTime.Now.Year)
            throw new Exception($"date of puplishing must be more than 1991 and less than {DateTime.Now.Year}");

        _description = description;
        DateOfPublishing = dateOfPublishing;
        Author = author;
        Name = name;
    }

    public string Description
    {
        get => _description;
        set { _description = value; }
    }
    public int? Rating
    {
        get => _rating;
        set
        {
            if (value >= 1 && value <= 5)
                _rating = value;
            else
                throw new Exception("Rating can be from 1 to 5");
        }
    }
    public string Author { get; private set; }
    public DateOnly DateOfPublishing { get; private set; }
    public string Name { get; private set; }
    public string GetInfo() => $"{Name}-{Author}-{DateOfPublishing.Year}";
}
