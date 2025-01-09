
using System;
namespace PatikaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();

            book1.BookName = "İdamlık Genç";
            book1.AuthorName = "Emine";
            book1.AuthorSurname = "Şenlikoğlu";
            book1.NumberOfPages = 250;
            book1.PublishingHouse = "Etiket";
            book1.BookInformation();

            Console.WriteLine("-------------------- 2. BOOK -----------------------------");

            Books books2 = new Books("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
            books2.BookInformation();

            Console.WriteLine("-----------------------");

        }
    }
}


