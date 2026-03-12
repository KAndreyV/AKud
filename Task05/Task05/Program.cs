using Microsoft.Data.SqlClient;


SqlConnection connection = new SqlConnection("Data Source=yand.dyndns.org,14333;Initial Catalog=AdventureWorks;Persist Security Info=True;User ID=northwind;Password=northwind;Encrypt=False;Trust Server Certificate=True");
StreamWriter productWriter = new StreamWriter("C:\\tmp\\Products100200.txt");
connection.Open();

string sql = "SELECT Name, ListPrice FROM Production.Product WHERE ListPrice>=100 and ListPrice<=200";
SqlCommand cmd = connection.CreateCommand();
cmd.CommandText = sql;

SqlDataReader reader = cmd.ExecuteReader();
while (reader.Read())
{
    productWriter.WriteLine(reader.GetString(0));
    Console.WriteLine(reader.GetString(0));
}


productWriter.Close();
connection.Close();


