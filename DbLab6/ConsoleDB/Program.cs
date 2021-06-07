using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLab6;
using MySql.Data.MySqlClient;

namespace ConsoleDB
{
    class ConsoleDb
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection...");
            MySqlConnection connection = DBUtils.GetDBConnection();
            try
            {
                Console.WriteLine("Opening connection...");
                connection.Open();
                Console.WriteLine("Connection successful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.Read();
        }
    }
}
