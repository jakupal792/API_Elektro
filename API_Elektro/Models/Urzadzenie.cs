using System;

namespace API_Elektro.Models
{
    public class Urzadzenie
    {
        public string nazwa { get; set; }
        public int ilosc { get; set; }
        public double moc { get; set; } //[W]
        public double czas { get; set; } //[h]

        // WŁAŚCIWOŚCI TYLKO DO ODCZYTU 

        public double zuzycie { get { return (ilosc * moc * czas / 1000.0); } } //[kWh]

        public double koszt { get { return zuzycie * UrzadzeniaService.cena; } } //[PLN]
    }
}
