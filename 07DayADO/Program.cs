using MySqlConnector;
using System.Data;

namespace _07DayADO
{
    internal class DisconnectedDemo
    {
        static string constr = @"server=localhost;userid=root;password=root;database=dac";
        static void Main(string[] args)
        {
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandText = "Select * from EMP;";
                    cmd.CommandText = "update emp ;";
                    using (MySqlDataAdapter d = new MySqlDataAdapter(cmd))
                    {
                        DataSet s = new DataSet();
                        d.Fill(s);
                        foreach (DataRow item in s.Tables[0].Rows)
                        {
                            Console.WriteLine(Convert.ToInt32(item[0]) + "-" + Convert.ToString(item[1]));
                        }

                    }

                    con.Close();
                }

            }
        }
    }
}