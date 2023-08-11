namespace EF7_Relacje.Model
{
    public class Author
    {
        // Relacja wielu do wielu z Autorem. Książka może mieć wielu autorów i autor może mieć wiele książek
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Wartość referencyjna do listy książek, które napisał autor.
        public List<Book> Books { get; set; }
    }
}
