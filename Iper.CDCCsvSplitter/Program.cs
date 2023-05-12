using System;

public class Program
{
    public static void Main(string[] args)

    {
        List<Info> lista = new List<Info>();
        lista = CsvRead.ReadCsv("C:\\temp\\dati.csv");

        foreach (Info person in lista)
        {
            Console.WriteLine(person.Cid);
        }
        Console.ReadLine();
    }
}
