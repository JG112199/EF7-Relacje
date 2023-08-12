namespace EF7_Relacje.Model
{
    public class Publisher
    {
        // Relacja jeden do wielu z Books. Książka ma jednego wydawcę, ale wydawca ma wiele książek
        public int Id { get; set; }
        public string? Name { get; set; }

        //wartość referencyjna do listy ksiazek, ktore posiada wydawca
        public List<Book>? Books { get; set; }
    }
}
