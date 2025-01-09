using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    public class Books   // KİTAP NESNESİ ŞABLONU   ----->   C#'ta class (sınıf), nesne tabanlı programlamanın temel yapı taşıdır. Sınıflar, veri (alanlar/fields) ve davranışları (metotlar/methods) bir arada tanımlayan şablonlardır. Sınıflar kullanılarak nesneler (objects) oluşturulur.
    {
        private string bookName;            //  {
        private string authorName;          //
        private string authorSurname;       //      
        private int numberOfPages;          //      Field'lar
        private string publishingHouse;     //
        private DateTime registrationDate;  //   }   ----> C#'da field (alan), bir sınıf içinde değişkenlerin tanımlandığı yerlerdir. Field'lar, bir sınıfın durumunu (state) saklamak için kullanılır ve genellikle özel (private) olarak tanımlanır. Field'lara genellikle sınıfın metotları veya özellikleri (property) aracılığıyla erişilir.


        public Books() //Parametresiz Constructor,   
        {
            RegistrationDate = DateTime.Now;
        }

        // C#'ta parametre almayan constructor (yapıcı metot), bir sınıfın örneği oluşturulduğunda varsayılan işlemleri gerçekleştiren ve herhangi bir parametre almayan bir metottur. Bu tür constructor'lar genellikle sınıf üyelerini varsayılan değerlere ayarlamak için kullanılır.

        public Books(string bookName, string authorName, string authorSurname, int numberOfPages, string publishingHouse) // Parametreli Constructor
        {
            BookName = bookName;
            AuthorName = authorName;
            AuthorSurname = authorSurname;
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            RegistrationDate = DateTime.Now;
        }
        // C#'ta parametre alan constructor (yapıcı metot), bir sınıfın örneği oluşturulurken başlangıç değerlerini belirlemek için kullanılan ve parametre kabul eden bir metottur. Bu, nesnelerin özel ihtiyaçlara göre oluşturulmasını sağlar.


        //PROPERTY'LER -----> C#'ta property (özellik), sınıfların (class) içinde tanımlanan ve genellikle sınıfın bir alanına (field) erişimi kontrol etmek için kullanılan bir yapıdır. Property'ler, bir sınıfın dışarıya bir değer sunmasını (get) veya dışarıdan bir değer almasını (set) sağlar. Property kullanımı, veri doğrulama ve gizlilik sağlamada önemlidir.
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public string AuthorSurname
        {
            get { return authorSurname; }
            set { authorSurname = value; }
        }
        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public string PublishingHouse
        {
            get { return publishingHouse; }
            set { publishingHouse = value; }
        }

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = DateTime.Now; }
        }

        // Field'ları kullanan bir metot
        public void BookInformation()
        {
            Console.WriteLine($"Kitap Adı: {bookName}, Yazar Adı ve Soyadı: {authorName} {authorSurname}, Sayfa Sayısı: {numberOfPages}, Yayınevi: {publishingHouse}, Kayıt Tarihi: {registrationDate} ");
        }

    }
}
