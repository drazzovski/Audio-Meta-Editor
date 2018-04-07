using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_meta_editor
{
    public class SortiranjeKat
    {
        private string kategorija;

        public string Kategorija
        {
            get { return kategorija; }
            set { kategorija = value; }
        }

        private string podKategorija;

        public string PodKategorija
        {
            get { return podKategorija; }
            set { podKategorija = value; }
        }

        public string Izdanja { get; set; }
        public string AlbumUrl { get; set; }




    }
}
