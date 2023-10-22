#region Create (C)

//using KategoriCalisma.Infrastructure.Context;
//using KategoriCalisma.Models.Concrete;

//using (AppDbContext db = new AppDbContext())
//{
//    Kategori kategori1 = new Kategori()
//    {
//        Aciklama = "Akıllı Telefon!",
//        Marka = "Iphone",
//        Model = "Iphone 15 PRO MAX",
//        Fiyat = 70000
//    };
//    Kategori kategori2 = new Kategori()
//    {
//        Aciklama = "Ev Telefonu!",
//        Marka = "Philips",
//        Model = "XL 4901S",
//        Fiyat = 2000
//    };
//    Kategori kategori3 = new Kategori()
//    {
//        Aciklama = "Tuşlu Telefon!",
//        Marka = "NOKIA",
//        Model = "3310",
//        Fiyat = 500
//    };
//    Kategori kategori4 = new Kategori()
//    {
//        Aciklama = "Ofis Telefonu!",
//        Marka = "KAREL",
//        Model = "TM-142",
//        Fiyat = 428
//    };
//    List<Kategori> kategoriler = new List<Kategori>
//    {
//        kategori1, kategori2, kategori3, kategori4
//    };
//    foreach (Kategori kategori in kategoriler)
//    {
//        db.Kategoriler.Add(kategori);
//        if (db.SaveChanges() > 0)
//        {
//            Console.WriteLine($"{kategori.Aciklama} Eklendi!");
//        }
//        else { Console.WriteLine($"{kategori} Eklenemedi!"); }
//    }
//}
#endregion

#region Read (R)

//using KategoriCalisma.Infrastructure.Context;
//using KategoriCalisma.Models.Concrete;

//using (var db = new AppDbContext())
//{
//    var kategoriler = db.Kategoriler.Where(x => x.Status != KategoriCalisma.Models.Abstract.Status.Passive).ToList();
//    foreach (Kategori kategori in kategoriler)
//    {
//        Console.WriteLine($"Id: {kategori.Id}\nAçıklama: {kategori.Aciklama}\nMarka: {kategori.Marka}\nModel: {kategori.Model}\nFiyat: {kategori.Fiyat}\nOluşturulma Zamanı: {kategori.CreatedDate}\nDurum: {kategori.Status}\n======================== ");
//    }
//}

#endregion

#region Update (U)

//using KategoriCalisma.Infrastructure.Context;

//using (var db =new AppDbContext())
//{
//    var kategori =db.Kategoriler.FirstOrDefault(x=>x.Id==4);
//    kategori.Aciklama = "Yeni Akıllı Telefon";
//    kategori.Marka = "Samsung";
//    kategori.Model = "S21 Ultra";
//    kategori.Fiyat = 70000;
//    kategori.Status = KategoriCalisma.Models.Abstract.Status.Modified;
//    kategori.UpdatedDate=DateTime.Now;
//    db.Kategoriler.Update(kategori);

//    if (db.SaveChanges() > 0)
//    {
//        Console.WriteLine("Kategori Güncellendi!");
//    }
//    else
//    {
//        Console.WriteLine("Kategori Güncellenemedi!");
//    }

//}

#endregion

#region Delete (D)

using KategoriCalisma.Infrastructure.Context;

using (var db =new AppDbContext())
{
    var kategori = db.Kategoriler.FirstOrDefault(x => x.Id == 4);
    kategori.DeletedDate=DateTime.Now;
    kategori.Status = KategoriCalisma.Models.Abstract.Status.Passive;
    db.Kategoriler.Update(kategori);
    if (db.SaveChanges()>0)
    {
        Console.WriteLine("Kategori Silindi!");
        var kategoriler = db.Kategoriler.Where(x => x.Status != KategoriCalisma.Models.Abstract.Status.Passive).ToList();
        Console.WriteLine();
        Console.WriteLine("Kategoriler: ");
        Console.WriteLine();
        foreach(var category in kategoriler)
        {
            Console.WriteLine(category.Marka);
        }
    }
}

#endregion