using System.Data;
using System.Data.SqlClient;

namespace ApartmanOtomasyon
{
    //data base icindeki prosedurlere degerleri atar ve tabloya ekler
    internal class SqlHelper
    {
        private string ConnectionString { get; set; }
        private SqlConnection Connection { get; set; }

        public SqlHelper()
        {
            ConnectionString = @"data source=LAPTOP-UI9DTME8\TEW_SQLEXPRESS;initial catalog=Apartman;trusted_connection=true";
            Connection = new SqlConnection(ConnectionString);
        }
        public void ExecuteProc(string procName, params SqlParameter[] ps)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.AddRange(ps);
            cmd.Connection = Connection;
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable GetTable(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
