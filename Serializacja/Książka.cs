using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacja
{
    [Serializable]
    public class Książka
    {
        public string Tytuł { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public double Ocena { get; set; }

        public Książka()
        {
           
        }

        public Książka(string tytuł, string autor, int rokWydania, string gatunek, double ocena)
        {
            Tytuł = tytuł;
            Autor = autor;
            RokWydania = rokWydania;
            Gatunek = gatunek;
            Ocena = ocena;
        }
    }

    [Serializable]
    public class ListaKsiążek : IEnumerable<Książka>
    {
        public List<Książka> ksiazki = new List<Książka>();

        public ListaKsiążek()
        {

        }

        public void Add(Książka książka)
        {
            ksiazki.Add(książka);
        }

        public IEnumerator<Książka> GetEnumerator()
        {
            return ksiazki.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }  

    }

}
