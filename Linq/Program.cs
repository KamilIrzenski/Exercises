using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using FirstProject;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"C:\Users\Kamili\Downloads\googleplaystore6.csv";
            var googleApps = LoadGoogleAps(csvPath);

            //Display(googleApps);\

            //GetData(googleApps);
            // ProjectData(googleApps);
            //DivideData(googleApps);
            //OrderData(googleApps);
            // DataSetOperation(googleApps);
            // DataVerification(googleApps);
            //GroupData(googleApps);
            //GroupDataOperating(googleApps);
            PobierzDane(googleApps);
        }

        static void PobierzDane(IEnumerable<GoogleApp> googleApps)
        {
            var dane = googleApps.Where(x => x.Category == Category.EDUCATION && x.Rating > (decimal)4.1);
            var posortowaneDane = dane.OrderByDescending(x =>x.Rating);
            Display(posortowaneDane);
        }

        static void GroupDataOperating(IEnumerable<GoogleApp> googleApps)
        {
            var groupBy = googleApps.GroupBy(x => x.Category);

            foreach (var group in groupBy)
            {
                var averageReviews = group.Average(x => x.Reviews);
                var minReviews = group.Min(x => x.Reviews);
                var maxReviews = group.Max(x => x.Reviews);
                var sumReviews = group.Sum(x => x.Reviews);

                Console.WriteLine($"Srednia reviews {group.Key}");
                Console.WriteLine($"Min {minReviews}");
                Console.WriteLine($"Max {maxReviews}");
                Console.WriteLine($"Sum {sumReviews}");
                Console.WriteLine();
            }
        }

        static void GroupData(IEnumerable<GoogleApp> googleApps)
        {
            var groupBy = googleApps.GroupBy(x => new { x.Category, x.Type });

            foreach (var item in groupBy)
            {
                var key = item.Key;
                var apps = item.ToList();
                Console.WriteLine($"Displaing elements for group {item.Key.Category}, {item.Key.Type}");
                Display(apps);
            }

        }

        static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var allOperationResult = googleApps.Where(x => x.Category == Category.WEATHER).All(x => x.Reviews > 10);
            //var result = allOperationResult.Any()
            Console.WriteLine($"allOperationResult {allOperationResult}");
            var anyOperationResult = googleApps.Where(x => x.Category == Category.WEATHER).Any(x => x.Reviews > 2_000_000);

            Console.WriteLine($"AllOperation > 2M {anyOperationResult}");
        }


        static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
        {
            var paidAppsCategories = googleApps.Where(x => x.Type == Type.Paid).Select(a => a.Category).Distinct();

            Console.WriteLine($"Paid apps categories: {string.Join(", ", paidAppsCategories)}");
        }
        static void OrderData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedAppBeauty = googleApps.Where(x => x.Rating > (decimal)4.4 && x.Category == Category.BEAUTY);

            var sortedResult = highRatedAppBeauty.OrderByDescending(x => x.Rating)
                .ThenByDescending(x => x.Name)
                .Take(5);

            Display(sortedResult);
        }
        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedAppBeauty = googleApps.Where(x => x.Rating > (decimal)4.4 && x.Category == Category.BEAUTY);
            var firstFiveApp = highRatedAppBeauty.Take(5);

            Display(firstFiveApp);

        }


        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedApps = googleApps.Where(x => x.Rating > (decimal)4.6 && x.Category == Category.BEAUTY);

            Display(highRatedApps);

            var firstOrDefoultHighRatedApps = highRatedApps.FirstOrDefault(x => x.Reviews < 300);

            Display(firstOrDefoultHighRatedApps);
        }

        static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedApps = googleApps.Where(x => x.Rating > (decimal)4.6 && x.Category == Category.BEAUTY);
            var nameApps = highRatedApps.Select(x => x.Name);

            var dtos = highRatedApps.Select(x => new GoogleAppDto()
            {
                Name = x.Name,
                Reviews = x.Reviews
            });

            //foreach (var dto in dtos)
            //{
            //    Console.WriteLine($"{dto.Name}: {dto.Reviews}");
            //}

            var genres = highRatedApps.SelectMany(x => x.Genres);
            Console.WriteLine(string.Join(", ", genres));

        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }
        }

        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
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

    }
}
