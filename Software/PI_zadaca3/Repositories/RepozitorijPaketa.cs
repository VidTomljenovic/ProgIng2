using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using PI_zadaca3.Modules;

namespace PI_zadaca3.Repositories
{

    class RepozitorijPaketa
    {

        //public static Paket GetPaket(int id)
        //{
        //    Paket paket = null;
        //    string sql = $"Select * from where ID = {id}";
        //    DB.OpenConnection();
        //    var reader = DB.GetDataReader(sql);
        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        paket = CreateObject(reader);
        //        reader.Close();
        //    }
        //    return paket;
        //}
        public static List<Paket> GetPaketi()
        {
            List<Paket> paketi = new List<Paket>();
            string sql = "SELECT * FROM PaketUsluga";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Paket paket = CreateObject(reader);
                paketi.Add(paket);
            }
            reader.Close();
            DB.CloseConnection();
            return paketi;
        }
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
    }
}
