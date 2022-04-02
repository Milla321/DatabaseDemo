using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection k1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=False;");
            k1.Open();
            OleDbCommand p1 = new OleDbCommand("CREATE TABLE tabla (szam  INT , szoveg VARCHAR(50));", k1);

            try
            {
                p1.ExecuteNonQuery();

            }
            catch
            {
                Console.WriteLine("A tábla már létezik...");
                Console.ReadKey();

            }
            Random r = new Random();
            int mennyi = r.Next(5, 11);
            for (int db = 1; db <= mennyi; db++)
            {
                int szam = r.Next(1000000, 2000000);
                //string szoveg = "Egymillió-Ötszáznegyvenhatezer-Kettőszázharmincnyolc;"
                string szoveg = "Nem tudom a számnevet";
                p1 = new OleDbCommand($"INSERT INTO table VALUES({szam}, {szoveg}; k1");

                p1 = new OleDbCommand("INSERT INTO table VALUES(@szam,@szoveg);", k1);
                p1.Parameters.AddWithValue("@szam", szam);
                p1.Parameters.AddWithValue("@szoveg", szoveg);
                p1.ExecuteNonQuery();
                p1.Parameters.Clear();
            }
            SQLiteConnection k2 = new SQLiteConnection("Data Source=database.db;");
            k2.Open();
            MySqlConnection mySqlConnection = new MySqlConnection

}
                p4.Parameters.AddWithValue("@egyilk", db)



        }
    }
}
