﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DreamIT.Data
{
    public static class Connection
    {
        public static SqlConnection conn;
        static string conStrinng;
        public static SqlConnection Connect() {
            conStrinng = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            if (conn == null)
            {
                conn = new SqlConnection();
                conn.Open();
            }
            else {
                conn.Open();
            }
            return conn; 
        }
       
    }
}
