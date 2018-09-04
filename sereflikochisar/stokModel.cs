using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sereflikochisar
{
    class stokModel
    {
        public int urunID { get; set; }
        public int ayarID { get; set; }
        public int kategoriID { get; set; }
        public decimal gram { get; set; }
        public decimal milyem { get; set; }
        public int firmaID { get; set; }
        public DateTime giristarih { get; set; }
        public DateTime cikistarih { get; set; }
        public string barkod { get; set; }
        public int satisfiyat { get; set; }
        public string kategoriAd { get; set; }
        public string firmaAd { get; set; }

    }
}
