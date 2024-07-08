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
            return new Paket
            {
                ID = int.Parse(reader["ID"].ToString()),
                ImePaketa = reader["ImePaketa"].ToString(),
                OpisPaketa = reader["OpisPaketa"].ToString(),
                NapomenaPaketa = reader.IsDBNull(reader.GetOrdinal("NapomenaPaketa")) ? null : reader["NapomenaPaketa"].ToString(),
                CijenaPaketa = int.Parse(reader["CijenaPaketa"].ToString())
            };
        }

        public static Paket GetPaket(int id)
        {
            return GetPaketi().FirstOrDefault(p => p.ID == id);
        }
        public static string GetImePaketa(int id)
        {
            return GetPaket(id)?.ImePaketa ?? string.Empty;
        }

        public static string GetOpisPaketa(int id)
        {
            return GetPaket(id)?.OpisPaketa ?? string.Empty;
        }

        public static string GetNapomenaPaketa(int id)
        {
            return GetPaket(id)?.NapomenaPaketa ?? string.Empty;
        }

        public static string GetCijenaPaketa(int id)
        {
            return GetPaket(id)?.CijenaPaketa.ToString() ?? string.Empty;
        }

        public static void DeletePaket(int id)
        {
            string sql = "DELETE FROM PaketUsluga WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(Conn.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePaketExceptID(int id, string imePaketa, string opisPaketa, string napomenaPaketa, int cijenaPaketa)
        {
            string sql = @"UPDATE PaketUsluga SET ImePaketa = @imePaketa, OpisPaketa = @opisPaketa, NapomenaPaketa = @napomenaPaketa, CijenaPaketa = @cijenaPaketa WHERE ID = @id";
            using (SqlConnection connection = new SqlConnection(Conn.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@imePaketa", imePaketa);
                    command.Parameters.AddWithValue("@opisPaketa", opisPaketa);
                    command.Parameters.AddWithValue("@napomenaPaketa", napomenaPaketa ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@cijenaPaketa", cijenaPaketa);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}