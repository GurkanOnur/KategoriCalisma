using KategoriCalisma.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KategoriCalisma.Models.Concrete
{
    public class Kategori : BaseItem
    {
        public string Aciklama { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }
    }
}
