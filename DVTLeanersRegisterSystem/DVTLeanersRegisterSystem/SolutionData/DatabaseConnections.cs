using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVTLeanersRegisterSystem.SolutionData
{
    class DatabaseConnections
    {
        public DatabaseConnections()
        {
            com = new SqlCommand("", Sqlcon);
        }
        private static SqlCommand com;
        private static SqlConnection Sqlcon = new SqlConnection(@"Server=DVT-TSCHAUKE\SQL2012;Database=TheDailyRegisterDba;Trusted_Connection=Yes;");
    }
}
