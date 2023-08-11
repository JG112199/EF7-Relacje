namespace EF7_Relacje.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //wartość referencyjna do listy ksiazek, ktore posiada wydawca
        public List<Book> Books { get; set; }
    }
}
