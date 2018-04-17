using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;


namespace Project.Database
{
    class DB_Connect
    {

        public static OracleConnection DBConnect()
        {
            String connect_Str = "DATA SOURCE=XE;USER ID=SYSTEM;PASSWORD=1234";
            OracleConnection con = null;
            con = new OracleConnection(connect_Str);

            return con;
        }
    }
}
