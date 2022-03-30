using System.Data.SqlClient;

namespace OlisWork
{
    internal class SqlCURD
    {
        public SqlCURD(string cmdline)
        {
            SqlConnection con = new SqlConnection("Data Source=PC-OLI;Initial Catalog=WorkDataControl_Student;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(cmdline, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
