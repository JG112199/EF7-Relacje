namespace EF7_Relacje.Model
{
    public class Book
    {
        //Relacja jeden do jednego z ISBN - jedna ksiazka posiada jeden isbn i jeden isbn jest przypisany do jednej ksiazki
        public int Id { get; set; }
        public string Title { get; set; }

        //Wartość referencyjna do kodu ISBN w relacji jeden do jednego Book - Isbn
        public Isbn Isbn { get; set; }
    }
}
