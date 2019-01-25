using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class DataConnection
    {
        string conStr; 
        public DataConnection() //ham khoi tao 1 chuoi ket noi
        {
            conStr = "Data Source = HUYVU-PC\\SQLEXPRESS; Initial Catalog=QLSV; Integrated Security=true";
        }
        public SqlConnection getConnect() //ham lay chuoi ket noi tu sql server
        {
            return new SqlConnection(conStr);
        }
    }
}
