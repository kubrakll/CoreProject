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
         */
    }
}
