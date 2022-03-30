using System;
using System.Collections.Generic;
using System.Text;

namespace Linq2
{
    public class GoogleApp
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Rating { get; set; }
        public int Reviews { get; set; }
        public string Size { get; set; }
        public string Installs { get; set; }
        public Type Type { get; set; }
        public string Price { get; set; }
        public string ContentRating { get; set; }
        public string Genres { get; set; }
        public DateTime LastUpdated { get; set; }

        public override string ToString()
        {
            return $"{Name, -50}  | " +
                   $"{Category, -22}  | " +
                   $"{Rating, -3}  | " +
                   $"{Reviews,-10}  | " +
                   $"{Size, -4}  |" +
                   $"{Installs,-10}  | " +
                   $"{Type,-5}  | " +
                   $"{Price,-3}  |" +
                   $"{ContentRating,-12}  | " +
                   $"{Genres,-20}  | " +
                   $"{LastUpdated.ToShortDateString(),-10}  ";
        }

    }
}
