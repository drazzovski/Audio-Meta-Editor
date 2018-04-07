using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_meta_editor
{
    public class Kategorije
    {
        public string Kategorija { get; set; }
        public string KategorijaUrl { get; set; }
        public Potkategorije PotKat { get; set; }

    }
}
