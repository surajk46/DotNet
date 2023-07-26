using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07DayADO
{
    internal class Emp
    {

            static string constr = @"server=localhost;userid=root;password=root;database=hibernatedb";
            static void Main(string[] args)
            {
                Console.WriteLine("========Display Data========");
                DisplayData();
                /*Console.WriteLine("========Data Inserted========");
                InsertData();*/
                /*Console.WriteLine("========Data Updated========");
                UpdateData();*/
                /*Console.WriteLine("========Data Deleted========");
                DeleteData();*/
                Console.WriteLine("========Data Count========");
                DisplayCount();
            }

            public static void InsertData()
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandText = "Insert into emp values(@id,@basic,@contactno,@email,@name)";
                        cmd.Parameters.AddWithValue("@id", 5);
                        cmd.Parameters.AddWithValue("@basic", 23000.0f);
                        cmd.Parameters.AddWithValue("@contactno", "8777234312");
                        cmd.Parameters.AddWithValue("@email", "tushar123@gmail.com");
                        cmd.Parameters.AddWithValue("@name", "tushar");

                        int res = cmd.ExecuteNonQuery();
                        Console.WriteLine("Record Inserted : " + res);
                        con.Close();
                    }

                }
            }
            private static void DisplayData()
            {
                /* using (MySqlConnection con = new MySqlConnection(constr))
                 {
                     con.Open();
                     using (MySqlCommand cmd = new MySqlCommand())
                     {

                         cmd.Connection = con;
                         cmd.CommandText = "Select * from emp;";

                         using (MySqlDataAdapter d = new MySqlDataAdapter(cmd))
                         {
                             DataSet s = new DataSet();
                             d.Fill(s);
                             foreach (DataRow item in s.Tables[0].Rows)
                             {
                                 Console.WriteLine(Convert.ToInt32(item[0]) + "-" + Convert.ToDecimal(item[1]) + "-" + Convert.ToString(item[2]) + "-" + Convert.ToString(item[3]) + "-" + Convert.ToString(item[4]));
                             }

                         }

                         con.Close();
                     }
                 }*/
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandText = "Select * from emp;";
                        MySqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Console.WriteLine(rd.GetInt32(0) + "-" + rd.GetFloat(1) + "-" + rd.GetString(2) + "-" + rd.GetString(3) + "-" + rd.GetString(4));
                        }

                        con.Close();
                    }

                }
            }
            private static void UpdateData()
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandText = "Update emp set name= @name where id=@id";
                        cmd.Parameters.AddWithValue("@id", 5);
                        cmd.Parameters.AddWithValue("@name", "Tushar");


                        int res = cmd.ExecuteNonQuery();
                        Console.WriteLine("Record Updated : " + res);
                        con.Close();
                    }

                }
            }

            private static void DeleteData()
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandText = "Delete from emp where Id=@id";
                        cmd.Parameters.AddWithValue("@id", 5);


                        int res = cmd.ExecuteNonQuery();
                        Console.WriteLine("Record Deleted : " + res);
                        con.Close();
                    }

                }
            }

            private static void DisplayCount()
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        cmd.Connection = con;
                        cmd.CommandText = "Select count(*) from emp";

                        var res = cmd.ExecuteScalar();
                        Console.WriteLine("Record Count : " + res);
                        con.Close();
                    }

                }
            }

        }

    }

