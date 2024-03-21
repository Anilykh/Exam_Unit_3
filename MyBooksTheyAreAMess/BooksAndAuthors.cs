public class Library
{
    private List<Book> books;

    public Library(List<Book> books)
    {
        this.books = books;
    }

    public List<Book> GetBooksStartingWithThe()
    {
        return books.Where(b => b.Title.StartsWith("The")).ToList();
    }

    public List<Book> GetBooksWrittenByAuthorsWithTInName()
    {
        return books.Where(b => b.Author.Contains("t")).ToList();
    }

    public int GetNumberOfBooksWrittenAfter(int year)
    {
        return books.Count(b => b.Year > year);
    }

    public int GetNumberOfBooksWrittenBefore(int year)
    {
        return books.Count(b => b.Year < year);
    }

    public List<string> GetISBNsByAuthor(string author)
    {
        return books.Where(b => b.Author.Equals(author)).Select(b => b.ISBN).ToList();
    }

    public List<Book> ListBooksAlphabetically(bool ascending)
    {
        return ascending ? books.OrderBy(b => b.Title).ToList() : books.OrderByDescending(b => b.Title).ToList();
    }

    public List<Book> ListBooksChronologically(bool ascending)
    {
        return ascending ? books.OrderBy(b => b.Year).ToList() : books.OrderByDescending(b => b.Year).ToList();
    }

    public Dictionary<string, List<Book>> GroupBooksByAuthorLastName()
    {
        return books.GroupBy(b => b.Author.Split(' ').Last()).ToDictionary(g => g.Key, g => g.ToList());
    }

    public Dictionary<string, List<Book>> GroupBooksByAuthorFirstName()
    {
        return books.GroupBy(b => b.Author.Split(' ').First()).ToDictionary(g => g.Key, g => g.ToList());
    }

}

class task_4
{
static void Main(string[] args)
    {
        var books = new List<Book>
        {
            new Book { Title = "Rhythm of War", PublicationYear = 2020, Author = "Brandon Sanderson", ISBN = "978-0765326386" },
            new Book { Title = "Trigger Warning: Short Fictions and Disturbances", PublicationYear = 2015, Author = "Neil Gaiman", ISBN = "0-06-233026-8" },
            new Book { Title = "Making Money", PublicationYear = 2007, Author = "Terry Pratchett", ISBN = "0-385-61100-6" },
            new Book { Title = "Elantris", PublicationYear = 2005, Author = "Brandon Sanderson", ISBN = "978-0765350374" },
            new Book { Title = "Moving Pictures", PublicationYear = 1990, Author = "Terry Pratchett", ISBN = "0-575-04696-5" },
            new Book { Title = "Men at Arms", PublicationYear = 1993, Author = "Terry Pratchett", ISBN = "0-575-05508-X" },
            new Book { Title = "Odd and the Frost Giants", PublicationYear = 2008, Author = "Neil Gaiman", ISBN = "0-06-167173-8" },
            new Book { Title = "American Gods", PublicationYear = 2001, Author = "Neil Gaiman", ISBN = "0-380-97365-0" },
            new Book { Title = "The Light Fantastic", PublicationYear = 1986, Author = "Terry Pratchett", ISBN = "0-86140-203-0" }
        };
    }
}


public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public int Year { get; set; }
    public string ISBN { get; set; }
}