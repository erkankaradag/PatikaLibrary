# PatikaLibrary Projesi

Bu proje, basit bir kitap yönetim sistemi oluşturmayı amaçlayan bir C# uygulamasıdır. Proje kapsamında, kitap nesnelerinin özellikleri ve bu özelliklerin nasıl kullanılacağına dair temel kavramlar ele alınmaktadır. Nesne tabanlı programlamanın (OOP) temel ilkeleri projede uygulanmıştır.

---

## Projenin Özellikleri
- **Kitap Sınıfı (Books)**: Kitap nesnelerini temsil eden bir sınıf oluşturulmuştur. Bu sınıf:
  - Kitap adı, yazar adı, yazar soyadı, sayfa sayısı, yayınevi ve kayıt tarihi gibi özelliklere sahiptir.
  - `BookInformation` metodu ile kitap bilgilerini ekrana yazdırır.
  - Parametresiz ve parametreli constructor  - Parametresiz ve parametreli constructor\u201lar içerir.

- **Program Sınıfı (Program)**:
  - `Main` metodunda farklı kitap nesneleri oluşturulur ve bu nesnelerle işlemler yapılır.
  - Kitap bilgileri konsola yazdırılır.

---

## Kullanılan Teknolojiler
- **Programlama Dili**: C#
- **IDE**: Visual Studio (veya herhangi bir C# uyumlu IDE)

---

## Kullanım
### 1. Kitap Oluşturma
Kitaplar, `Books` sınıfı kullanılarak oluşturulabilir. Sınıf, aşağıdaki özellikleri içerir:
- `BookName`: Kitabın adı.
- `AuthorName`: Yazarın adı.
- `AuthorSurname`: Yazarın soyadı.
- `NumberOfPages`: Kitabın sayfa sayısı.
- `PublishingHouse`: Yayınevi adı.
- `RegistrationDate`: Kitabın kayıt tarihi (otomatik olarak atanır).

### 2. Kitap Bilgilerini Yazdırma
Her bir kitap nesnesi, `BookInformation` metodu ile bilgilerini konsola yazdırabilir.

### Örnek Kullanım
```csharp
Books book1 = new Books("İdamlık Genç", "Emine", "Şelnikoğlu", 250, "Etiket");
book1.BookInformation();
```

---

## Örnek Çıktı
```
Kitap Adı: İdamlık Genç, Yazar Adı ve Soyadı: Emine Şelnikoğlu, Sayfa Sayısı: 250, Yayınevi: Etiket, Kayıt Tarihi: 09.01.2025 15:30:00
-----------------------
Kitap Adı: Adı Aylin, Yazar Adı ve Soyadı: Ayşe Kulin, Sayfa Sayısı: 398, Yayınevi: Remzi Kitabevi, Kayıt Tarihi: 09.01.2025 15:30:00
```

---

## Geliştirme Önerileri
- Kitaplara kategori veya ISBN gibi yeni özellikler eklenebilir.
- Kitaplar bir veritabanında saklanabilir.
- Konsol tabanlı arayüz yerine bir web veya masaüstü uygulaması yapılabilir.

---

## Lisans
Bu proje MIT Lisansı altında lisanslanmıştır.

