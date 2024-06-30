using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace PI_zadaca3.Repositories
{
    class RepozitorijPaketa
    {
        public static PregledPaketa GetPaket(int id)
        {
            PregledPaketa paket = null;
            string sql = $"Select * from where ID = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                paket = CreateObject(reader);
                reader.Close();
            }
            return paket;
        }
    }
}
