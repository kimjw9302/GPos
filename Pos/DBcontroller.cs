using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos
{
    /// <summary>
    /// SqlConnection 싱글턴을 위해 만든 클래스.
    /// </summary>
    class DBcontroller
    {
        static private SqlConnection con = null;
        private DBcontroller()
        {
            
        }
        static public SqlConnection Instance()
        {
            if (con == null)
            {
                con = new SqlConnection();
            }
            return con;
        }

    }
}
