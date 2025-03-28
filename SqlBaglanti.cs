using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon
{
    public class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=192.168.1.8;Initial Catalog=ZorluMotorDB;User ID=zorlu;Password=v.1;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
