using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP3_meta_editor
{
    public class Inputs : IEnumerable<Inputs>
    {
        public int IdInput { get; set; }
        public string Putanja { get; set; }
        public string Naziv { get; set; }
        public string Ekstenzija { get; set; }

        public IEnumerator<Inputs> GetEnumerator()
        {
            return myInputs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        List<Inputs> myInputs = new List<Inputs>();

        public Inputs this[int index]
        {
            get { return myInputs[index]; }
            set { myInputs.Insert(index, value); }
        }

    }







}
