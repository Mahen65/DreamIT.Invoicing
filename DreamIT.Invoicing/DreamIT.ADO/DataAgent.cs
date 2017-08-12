using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DreamIT.ADO;

namespace DreamIT.Data
{
    public class DataAgent
    {
        DataTable dt;
        public DataAgent()
        {
            dt = new DataTable();
        }
        public List<T> ReturnListFromNonQuery<T>(string query) where T : class
        {
            dt.Clear();
            SqlCommand cmd = new SqlCommand(query, Connection.Connect());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            List<T> list = Comman.ConvertDataTable<T>(dt);
            return list;
        }
        public List<T> ReturnListFromParameters<T>(string query, SqlParameter[] param) where T : class
        {
            dt.Clear();
            SqlCommand cmd = new SqlCommand(query, Connection.Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter para in param)
            {
                cmd.Parameters.Add(para);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            List<T> list = Comman.ConvertDataTable<T>(dt);
            return list;
        }
        public int InsertInTo(string query, SqlParameter[] param)
        {
            int i = 0;
            dt.Clear();
            SqlCommand cmd = new SqlCommand(query, Connection.Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter para in param)
            {
                cmd.Parameters.Add(para);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i=Convert.ToInt32(dt.Rows[0][0]);
            return i;
        }

    }
}
