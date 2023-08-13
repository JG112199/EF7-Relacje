namespace EF7_Relacje.Model
{
    public class Book
    {
        // Relacja jeden do jednego z ISBN. Jedna ksiazka posiada jeden isbn i jeden isbn jest przypisany do jednej ksiazki
        // Relacja jeden do wielu z Wydawcą. Książka ma jednego wydawcę, ale wydawca ma wiele książek
        // Relacja wielu do wielu z Autorem. Książka może mieć wielu autorów i autor może mieć wiele książek
        public int Id { get; set; }
        public string? Title { get; set; }

        // Nawigacja referencyjna do kodu ISBN w relacji jeden do jednego Book - Isbn
        public Isbn? Isbn { get; set; }

        // Foreign Key do Publisher
        public int PublisherId { get; set; }

        // Nawigacja referencyjna do wydawcy
        public Publisher? Publisher { get; set; }

        // Nawigacja referencyjna do autorów danej książki
        public List<Author>? Authors { get; set; }
    }
}
