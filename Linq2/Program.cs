using System;
using System.Collections.Generic;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {

            var path = @"C:\Users\Kamili\Downloads\googleplaystore6.csv";
            var result = LoadGoogleAps(path);

            Display(result);

            //Console.WriteLine("Hello World!");
        }

        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var GetDataTating = googleApps.Where(x =>x.)
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }
        }

        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }
        }
    }
}
