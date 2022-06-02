using API_Elektro.Models;
using System.Collections.Generic;
using System.Linq;

namespace API_Elektro
{
    public class UrzadzeniaService
    {
        public static double cena { get; set; } //zł za kWh
 
        private static List<Urzadzenie> Urzadzenia = new List<Urzadzenie>  
        { };

        public IEnumerable<Urzadzenie> Pobierz()
        {
            return Urzadzenia;
        }

        public IEnumerable<Urzadzenie> Dodaj(Urzadzenie u)
        {
            Urzadzenia.Add(u);
            return Urzadzenia;
        }

        public IEnumerable<Urzadzenie> Wyczysc()
        {
            Urzadzenia.Clear();
            return Urzadzenia;
        }

        public IEnumerable<Urzadzenie> Usun(string nazwa)
        {
            Urzadzenia = Urzadzenia.FindAll(u => u.nazwa != nazwa);
            return Urzadzenia;
        }

        public IEnumerable<Urzadzenie> UstawCene(double cena)
        {
            UrzadzeniaService.cena = cena;
            return Urzadzenia;
        }
    }
}