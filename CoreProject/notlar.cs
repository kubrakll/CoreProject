using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject
{
    public class notlar
    {
        /*
         * Adım: Katmanlar oluşturulur.
         * Entity Layer, Data Access Layer, Business Layer, Presentation Layer, Core Layer, Api
         * Solution üzerinde sağ tık > new project > class libray 
         * 
         * Adım: Entitylerin Oluşturulur.
         * Makale, Kategori, Yorumlar, Yazarlar, Hakkımda, İletişim, Adress, 
         * Önce Concrete klasörü oluşturulur ve doldurulur.
         * 
         * Entity Framework Core Paketleri Yüklenmesi bunlar; Data Access > Manage > (Entity Framework Core + Entity Framework Core.Design + Entity Framework Core.SqlServer + Entity Framework Core.Tools
         * 
         * Adım: Data Access de klasörlerin oluşturulması. Concrete, Abstract, Repositories
         * 
         * Adım: Connection String Ve Context Sınıfı oluşturulması
         * Data>Concrete>Context
         * Referans verilir; Data>Dependencies>sağ tık>add project referans>Entity
         *                   BusinessLayer>Dependencies>sağ tık>add project referans>Data Ac + Entity
         *                   UI Layer>Dependencies>sağ tık>add project referans>Data Ac + Entity + Business
         *                   
         * Adım: Migration İşlemleri 
         * coredemo' ya Entity paketleri eklenir. Entity Framework Core + Entity Framework Core.Design + Entity Framework Core.SqlServer + Entity Framework Core.Tools
         * 
         * Packege Manager Console > DataLayer(veritabanı bağlantı stringimiz data acceste) > add-migration mig1 > update-database
         * 
         * Adım: İlişkilerin Eklenmesi
         * Blog-Category
         * Blog-Comment
         * "ICollection" bir interface iken "List" ise bir class tır. "ICollection", aralarında "List" de bulunan ve "ICollection" interfaceini implemente eden herhangi bir classı veya bu classlardan türetilen herhangi bir classı alabilirken, "List" sadece kendini ve List den türetilen sınıfları kabul eder.
         * 
         * 
         * Adım:Interfacelerin Tanımlanması
         * DataAccess > Abstract > New Interface'ler eklenir ve doldurulur.
         * DRY (Don’t Repeat Yourself) prensibine göre kod içindeki her parçacığın kendine özelleştirilmiş bir yapısı, görevi olmalıdır. Aksi halde bir değişiklik yapılması gerektiğinde o parçadan etkilenen diğer parçalarda da değişiklik yapılması gerekir ki bu da çoğu zaman karmaşıklığa sebep olur. Kod tekrarından kaçınılmalı, tekrarlamalar soyutlama yolu ile aşılmalıdır.
         * 
         * 
         * Adım:Repositorylerin Yazılması
         *  DataAccess > Repositories > New Class'lar eklenir ve doldurulur.
         *  "using var c = new Context()" sadece o metota ait oluyor yani her metot içine ayrı ayrı yazmamız gerek,
         *  "Context c = new Context()" ise tüm metodların dışına yazıyoruz yani tümünü kapsıyor.
         *  Soru : Ado net de SaveChanges' in karşılığı nedir?
         *  Cevap: ExecuteNonQuery :)
         *  
         *  
         *  Adım: Generic Repository
         *  Tek Tek Repository yazmak yerine bu olarak generic hale getiriyor sebebi aynı işlemler sadece T değerleri farklı.
         *  Abstract > IGenericDal
         *  Repository > GenericRepository
         *  
         *  Adım: Managerların Yazılması --BusinessLayer
         *  DataAccess' e EntityFramework adında klasör eklenir.
         *  Abstract, ValidationRules ve Concrete klasörü oluşturulur ve içi doldurulur. Service ve Manager şeklinde. 
         *  Burdaki amaç validasyon kurallarına göre CRUD işlemlerini yapmaktır.
         *  DataAccess'e kalan entitiyler eklenir.
         *  EntityFramework klasörü doldurulur.
         *  Business Katmanı düzenlenir.
         *  
         *  
         *  Adım: Controller tanımlanması(Kategoriler)
         *  Kategori Manager düzenlenmesi
         *  Kategorilerin Listelenmesi işlemi
         *  
         *  Adım: Temanın Projeye Eklenmesi
         *  wwwroot içine eklenir.
         *  
         *  
         *  Adım: Views > Shared > Layout işlemi yapılması
         *  _UserLayout
         *  BlogController Eklenmesi
         *  
         *  Adım: Partial View Await Async Eklenmesi
         *  
         *  Adım: Blogların Listelenmesi
         *  BusinessLayer > Abstract > IBlogService eklenir ve doldurulur.
         *  BusinessLayer > Concrete > BlogManager eklenir ve doldurulur.
         *  BlogController Index Sayfası doldurulur.
         *  
         *  Adım: Include Metodu Ve Eager Load
         *  Bloglarda kategori adı yerine kategori id gözüküyordu bu durum düzeltildi.
         *  DataAccessLayer > IBlogDal içine yazılır.
         *  EfBlogRepository içeriği doldurulur. Repositories içeriğindeki kullanılmayan kısımlar silinir.
         *  IBlogService ve BlogManager ilgili kısımlar eklenir.
         *  Eager Loading: nesneyi ihtiyaç anından hemen önce oluşturur ve bekletir. Linq sorgusu çalıştırıldığında verilerin tamamını  yükler ve hafızaya alır. Daha ucuz maliyetlidir.
            Lazy Loading : Bu yöntemde veriler sorguya bağlı olarak çekilir ancak veri setinin içindeki tüm dataları yüklemek yerine verilerin çağrıldıkça otomatik yüklenmesi söz konusudur. Daha pahalı işlemdir.
         *  
         *  Adım: Blog Detaylandırılması
         *  ReadMore kısmına karakter kısıtlaması getirilmesi yapıldı.
         *  

         */
    }
}
