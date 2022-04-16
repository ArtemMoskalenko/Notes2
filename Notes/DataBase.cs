using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Notes
{
    class DataBase
    {
        SqlConnection SQLconnection = new SqlConnection(@"Data Source=ARTEM-PC\SQLEXPRESS; Initial Catalog= ListToEveyDay; Integrated Security=True");
        public void OpenConnection()
        {
            if (SQLconnection.State == System.Data.ConnectionState.Closed)

                SQLconnection.Open();

        }

        public void CloseConnection()
        {
            if (SQLconnection.State == System.Data.ConnectionState.Open)

                SQLconnection.Close();

        }
        public SqlConnection GetConnection()
        {
            return SQLconnection;
        }
    }
}

