using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_meta_editor
{
    public class Album : IEnumerable<Album>
    {
        
        public string Artist { get; set; }//+
        public string Naziv { get; set; }//+
        public string Genre { get; set; } //-
        public string Godina { get; set; } //-
        public string AlbumUrl { get; set; }//+
        public string ImageUrl { get; set; } //-
        public string Kategorija { get; set; }//+
        public string Potkategorija { get; set; }//+
        public int BrojVerzija { get; set; }
        public Dictionary<int, string> VerzijeUrl { get; set; }
        public List<Pjesma> Pjesme { get; set; }//

        public IEnumerator<Album> GetEnumerator()
        {
            return myAlbums.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        List<Album> myAlbums = new List<Album>();

        public Album this[int index]
        {
            get { return myAlbums[index]; }
            set { myAlbums.Insert(index, value); }
        }

    }
}
