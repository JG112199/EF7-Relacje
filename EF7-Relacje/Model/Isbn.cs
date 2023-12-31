﻿namespace EF7_Relacje.Model
{
    public class Isbn
    {
        // Relacja jeden do jednego z Books. Jedna ksiazka posiada jeden isbn i jeden isbn jest przypisany do jednej ksiazki
        public int Id { get; set; }
        public int IsbnCode { get; set; }

        // Foreign Key do tabeli Books
        public int BookId { get; set; }

        // Nawigacja referencyjna do książki w relecji jeden do jednego Book - Isbn
        public Book Book { get; set; } = null!;

    }
}
