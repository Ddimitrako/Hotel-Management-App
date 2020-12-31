using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    class Sqlparce
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = hotelmanagementsqlserver.database.windows.net;database=HotelManagementSqlDatabase;integrated Security=False;";
            con.ConnectionString= "Server=hotelmanagementsqlserver.database.windows.net,1433;Database=HotelManagementSqlDatabase;User ID=dimitris;Password=gigiriva1994!;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return con;
        }
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void SetData(String query, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("'" + message + "'", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
