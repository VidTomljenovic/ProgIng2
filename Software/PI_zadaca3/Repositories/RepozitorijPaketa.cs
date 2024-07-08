using System.Collections.Generic;
using System.Data.SqlClient;
using DBLayer;
using PI_zadaca3.Modules;

namespace PI_zadaca3.Repositories
{
    public partial class RepozitorijPaketa
    {
        /// Dohvaća sve pakete iz BP i vraća listu (svih) paketa
        public static List<Paket> GetPaketi()
        {
            List<Paket> paketi = new List<Paket>();
            string sql = "SELECT * FROM PaketUsluga";

            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);

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