using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DreamIT.Data;

namespace DreamIT.Data
{
    public class DataAgent
    {
        public List<T> ReturnListFromNonQuery<T>(string query) where T : class
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, Connection.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            List<T> list = Comman.ConvertDataTable<T>(dt);
            return list;
        }
    }
}
