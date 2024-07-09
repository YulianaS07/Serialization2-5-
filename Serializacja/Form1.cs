using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serializacja
{
    public delegate string DelegatKsiążek(Książka książka);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        
        ListaKsiążek listaKsiazek = new ListaKsiążek();
        string xmlFilePath = "C:\\Users\\yulia\\source\\repos\\Serializacja\\Serializacja\\książkixml.xml";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(xmlFilePath))
            {
                listaKsiazek = SerializerForXml.DeserializeFromXml<ListaKsiążek>(xmlFilePath);
                WyświetlamyKsiążki(listaKsiazek, Print);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Książka ksiazka = new Książka();
            ksiazka.Tytuł = textBoxTytul.Text;
            ksiazka.Autor = textBoxAutor.Text;
            ksiazka.RokWydania = int.Parse(textBoxRok.Text);
            ksiazka.Gatunek = textBoxGatunek.Text;
            ksiazka.Ocena = double.Parse(textBoxOcena.Text);

            listaKsiazek.Add(ksiazka);
            listBox1.Items.Clear();
            WyświetlamyKsiążki(listaKsiazek, Print);

            textBoxTytul.Clear();
            textBoxAutor.Clear();
            textBoxRok.Clear();
            textBoxGatunek.Clear();
            textBoxOcena.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SerializerForXml.SerializeToXml(listaKsiazek, xmlFilePath);
        }

        private string Print(Książka książka)
        {
            return $"Tytuł: '{książka.Tytuł}', Autor: {książka.Autor}, Rok wydania: {książka.RokWydania}, Gatunek: {książka.Gatunek}, Ocena: {książka.Ocena}";
        }

        private void WyświetlamyKsiążki(ListaKsiążek książki, DelegatKsiążek delegacik)
        {
            foreach (var książka in książki)
            {
                listBox1.Items.Add(delegacik(książka));
            }
        }

        public class SerializerForXml
        {
            public static void SerializeToXml<T>(T obj, string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, obj);
                }
            }
            public static T DeserializeFromXml<T>(string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(filePath))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
        }
    }
}
