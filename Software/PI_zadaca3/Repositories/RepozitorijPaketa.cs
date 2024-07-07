using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DBLayer;
using PI_zadaca3.Modules;

namespace PI_zadaca3.Repositories
{
    public partial class RepozitorijPaketa
    {
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
        
    }
}
