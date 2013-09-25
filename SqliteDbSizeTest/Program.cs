using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SqliteDbSizeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Path.Combine(Directory.GetCurrentDirectory(), "usercontacts");
            // Creates new sqlite database if it is not found
            using (var conn = new SQLiteConnection(@"Data Source=" + filename))
            {                
                conn.Open();
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                using (var cmd = new SQLiteCommand(conn))
                {                 
                    for (int i = 1; i < 1500; i++)
                    {
                        cmd.CommandText = "INSERT INTO contactdata VALUES ('" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" +
                            Guid.NewGuid().ToString() + "','" + 
                            Guid.NewGuid().ToString() + "');";                        
                        cmd.ExecuteNonQuery();
                    }            
                }

                Console.WriteLine("{0} seconds with one transaction.", stopwatch.Elapsed.TotalSeconds);                
            }
        }

    }
}
