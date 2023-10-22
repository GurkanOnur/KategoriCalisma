Entity Framework .NET CORE ile örnek bir DATABASE ACCESS çalışması yapacağız.

Entity Framework, .NET CORE veritabanlarıyla etkileşimde bulunmak için kullanılan bir framework'tür. Entity framework, .NET CORE uygulamalarında veritabanı işlemlerini kolaylaştırmak ve soyutlamak için kullanılır.

Entity Framework, veritabanı tablolarını .NET nesneleri ile eşlemek ve bu nesneler üzerinden veritabanı işlemleri yapmamıza imkan sağlar. Bu, geliştiricilere veritabanıyla çalışırken SQL sorguları yazmak yerine C# kodu kullanarak daha rahat ve verimli bir çalışma imkanı sağlar. Entity Framework, veritabanı bağlantısı, sorgular, veritabanı işlemleri ve nesne ilişkilendirmesi gibi bir dizi veritabanı işlemi için yardımcı olur.

Telefonlar ile ilgili bir kategori çalışması yapacağız. Marka, model, açıklama, fiyat, oluşturulma tarihi, güncellenme tarihi ve durumu yer alacak.

Çalışmamızı bu sıra ile yapacağız:
Models => Paketler => DbContext => Migration - Update Database => Program.cs (CRUD İşlemler)

1) KategoriCalisma adlı projemizde ilk olarak Models klasörünün içerisine Abstract klasörü ve onun da içerisine BaseItem sınıfını oluşturduk. Bu sınıf nesneleri tnaımlayan temel bir sınıftır. Bu sınıf nesnelerin tanımlayıcısı, oluşturulma, güncelleme ve silinme tarihiyle beraber durumu gibi özellikleri içerir. Bu sınıf direkt olarak temel alınarak nesneleri temsil etmek üzere kullanılabilecek somut sınıflar oluşturmak için kullanılır.

2) Ardından Models klasörünün içerisinde Concrete adlı klasör oluşturarak içerisine Kategori sınıfını ekledik. Kategori sınıfı BaseItem sınıfından miras alarak Id, CreatedDate, UpdatedDate, DeletedDate ve Status özelliklerine erişebilir. Aynı zamanda Kategori sınıfı kategori nesnelerini temsil ederken, bu nesnelerin temel özelliklerini miras aldığı anlamına gelir.

3) Package Manager Console'dan yüklenmesi gereken paketler;
1) install-package microsoft.entityframeworkcore.sqlserver -v 7.0.12
2) install-package microsoft.entityframeworkcore.tools -v 7.0.12
Paketleri yükledikten sonra Infrastructure kalsörü oluşturup içerisine Context klasörü, ardından AppDbContext sınıfını oluşturduk. Bu sınıf Entity Framework Core kullanarak bir veritabanı bağlantısını ve modelini tanımlayan C# sınıfını temsil eder. Böylelikle veritabanı bağlantısını yapılandırır ve veritabanı işlemleri için DbContext (Veritabanımızla uygulamamız arasında sorgulama, güncelleme, silme gibi işlemleri yapabilmemizi sağlar) oluşturur. AppDbContext sınıfı, EntityFramework Core kullanarak SQL Server veritabanına bağlanmak ve Kategori adlı sınıfı içeren veritabanı modelini temsil etmek ve uygulama tarafından veritabanı işlemleri yapmak için kullanılır.

4) 3.aşamada yüklediğimiz paketlerden sonra database'e rehberlik etmesi için Package Manager Console'a add-migration InitialCreate3 yazdık. Veritabanı yapısında değişiklik yapıldığında veritabanı yeniden oluşturulur. Bu değişikliklerse migration ile sağlanır. Migration oluşturulduktan sonra bu migration'a göre database oluşturma işlemi içinse update-database komutunu çalıştırıyoruz.

5) Son aşamada (Program.cs) CRUD işlemler yaptık. Nedir bu CRUD işlemler; bir veritabanı ile bağdaştırılmış temel veri işlemlerini ifade eder. Create(C)-Read(R)-Update(U)-Delete(D) kelimelerinin baş harflerinden oluşur. Veri yönetimi ve işlemleri için temel bir yapı oluşturulur ve uygulamalarda veriye erişmek ve yönetmek için kullanılır.