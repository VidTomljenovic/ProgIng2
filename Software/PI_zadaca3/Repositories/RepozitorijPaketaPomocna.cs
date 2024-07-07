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

        internal static Paket GetPaket(object id)
        {
            throw new NotImplementedException();
        }

        public static Paket GetPaket(int id)
        {
            // Implementirajte logiku za dohvaćanje Paket-a iz baze podataka ili gdje god je pohranjen
            // Za potrebe demonstracije, pretpostavljamo da imate listu objekata Paket
            List<Paket> paketi = GetPaketi(); // Pretpostavka: GetPaketi() dohvaća sve objekte Paket
            return paketi.FirstOrDefault(p => p.ID == id);
        }

        public static string GetImePaketa(int id)
        {
            Paket paket = GetPaket(id);
            if (paket != null)
            {
                return paket.ImePaketa;
            }
            return string.Empty; // ili null, ovisno o vašim potrebama
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
        public static void DeletePaket(int id)
        {
            string sql = "DELETE FROM PaketUsluga WHERE ID = @ID";
            string connectionString = Conn.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public static void UpdatePaketExceptID(int id, string imePaketa, string opisPaketa, string napomenaPaketa, int cijenaPaketa)
        {
            // Connection string za vašu bazu podataka
            string connectionString = Conn.GetConnectionString();

            // SQL upit za ažuriranje informacija o paketu, isključujući ID
            string sql = @"UPDATE PaketUsluga SET ImePaketa = @imePaketa, OpisPaketa = @opisPaketa, NapomenaPaketa = @napomenaPaketa, CijenaPaketa = @cijenaPaketa WHERE ID = @id";

            // Definiranje veze i komande za izvršenje upita
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Dodavanje parametara
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@imePaketa", imePaketa);
                    command.Parameters.AddWithValue("@opisPaketa", opisPaketa);
                    command.Parameters.AddWithValue("@napomenaPaketa", napomenaPaketa ?? (object)DBNull.Value); // Rukovanje null vrijednostima
                    command.Parameters.AddWithValue("@cijenaPaketa", cijenaPaketa);

                    // Otvorite vezu i izvršite upit
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}