using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DBLayer;
using PI_zadaca3.Modules;

namespace PI_zadaca3.Repositories
{
    public partial class RepozitorijPaketa
    {
        private static Paket CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string imePaketa = reader["ImePaketa"].ToString();
            string opisPaketa = reader["OpisPaketa"].ToString();
            string napomenaPaketa;
            if (!reader.IsDBNull(reader.GetOrdinal("NapomenaPaketa")))
            {
                napomenaPaketa = reader["NapomenaPaketa"].ToString();
            }
            else
            {
                napomenaPaketa = null; // ili prazan string "", ovisno o vašim potrebama
            }
            int cijenaPaketa = int.Parse(reader["CijenaPaketa"].ToString());
            var paket = new Paket
            {
                ID = id,
                ImePaketa = imePaketa,
                OpisPaketa = opisPaketa,
                NapomenaPaketa = napomenaPaketa,
                CijenaPaketa = cijenaPaketa
            };
            return paket;
        }

        public static Paket GetPaket(int id)
        {
            // Implementirajte logiku za dohvaćanje Paket-a iz baze podataka ili gdje god je pohranjen
            // Za potrebe demonstracije, pretpostavljamo da imate listu objekata Paket
            List<Paket> paketi = GetPaketi(); // Pretpostavka: GetPaketi() dohvaća sve objekte Paket
            return paketi.FirstOrDefault(p => p.ID == id);
        }

        public static string GetOpisPaketa(int id)
        {
            // Logika za dohvat OpisPaketa iz baze ili liste objekata
            Paket paket = GetPaket(id); // Pretpostavka: metoda koja dohvaća paket po ID-u
            if (paket != null)
            {
                return paket.OpisPaketa;
            }
            return string.Empty; // ili null, ovisno o potrebama
        }
        public static string GetNapomenaPaketa(int id)
        {
            // Logika za dohvat OpisPaketa iz baze ili liste objekata
            Paket paket = GetPaket(id); // Pretpostavka: metoda koja dohvaća paket po ID-u
            if (paket != null)
            {
                return paket.NapomenaPaketa;
            }
            return string.Empty; // ili null, ovisno o potrebama
        }
        public static string GetCijenaPaketa(int id)
        {
            Paket paket = GetPaket(id);
            if (paket != null)
            {
                return paket.CijenaPaketa.ToString();
            }
            else
            {
                return ""; // ili null, ovisno o vašim preferencijama
            }
        }
    }
}