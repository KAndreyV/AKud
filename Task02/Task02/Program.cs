StreamReader namesReader = new StreamReader("C:\\tmp\\names.txt");
StreamWriter namesWriter = new StreamWriter("C:\\tmp\\results.txt");


while (!namesReader.EndOfStream)
{
    string name = namesReader.ReadLine();
    if (!string.IsNullOrEmpty(name) && name.Substring(0, 1) == "V")
    {
        namesWriter.WriteLine(name);
        Console.WriteLine(name);
    }
}


namesReader.Close();
namesWriter.Close();
