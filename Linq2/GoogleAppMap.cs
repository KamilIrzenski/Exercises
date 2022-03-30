using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;

namespace Linq2
{
    public class GoogleAppMap : ClassMap<GoogleApp>
    {
        public GoogleAppMap()
        {
            Map(m => m.Name).Name("Name");
            Map(m => m.Category).Name("Category");
            Map(m => m.Rating).Name("Rating");
            Map(m => m.Reviews).Name("Reviews");
            Map(m => m.Size).Name("Size");
            Map(m => m.Installs).Name("Installs");
            Map(m => m.Type).Name("Type");
            Map(m => m.Price).Name("Price");
            Map(m => m.ContentRating).Name("ContentRating");
            Map(m => m.Genres).Name("Genres");
            Map(m => m.LastUpdated).Name("LastUpdated");
        }
    }
}
