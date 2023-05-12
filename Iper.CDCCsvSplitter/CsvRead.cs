using System;
using CsvHelper;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;

public class CsvRead
{
    public static List<Info> ReadCsv(string csvpath)
    {
        List<Info> list = new List<Info>();
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = false,
            MissingFieldFound = null,
        };
        using (StreamReader sr = new StreamReader(csvpath))
        using (CsvReader csv = new CsvReader(sr, config))
        {
            while (csv.Read())
            {
                list = csv.GetRecords<Info>().ToList();
            }

           
        }

        return list;
    }
}
