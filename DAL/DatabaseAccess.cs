using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Reflection;
using System.ComponentModel;
using System.Reflection.Emit;
using System.CodeDom;

namespace DAL
{
    public class Connection
    {
        private static string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project_CSharp\Library_Management\DAL\LibraryDB.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
    public class DatabaseAccess
    {
        SqlCommand sqlCommand;
        SqlDataReader reader;
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(query, sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(reader.GetString(4), reader.GetString(5)));
                }
                sqlConnection.Close();
            }
            return taiKhoans;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
        public DataSet ShowData(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {                
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);

                DataSet ds = new DataSet();
                da.Fill(ds);
                //grid.DataSource = ds.Tables[0];
                sqlConnection.Close();       
                return ds;
            }
        }
    }
}
