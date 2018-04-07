using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_meta_editor
{
    public class Pjesma : IEnumerable<Pjesma>
    {
        public uint Id { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string NazivPjesme { get; set; }
        public string Genre { get; set; }
        public string Godina { get; set; }

        public IEnumerator<Pjesma> GetEnumerator()
        {
            return myPjesme.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        List<Pjesma> myPjesme = new List<Pjesma>();

        public Pjesma this[int index]
        {
            get { return myPjesme[index]; }
            set { myPjesme.Insert(index, value); }
        }
    }
}
