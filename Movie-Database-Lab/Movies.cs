using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database_Lab
{
    internal class Movies
    {
        public string movieTitle;
        public string movieCategory;

        public Movies(string title, string category)
        {
            movieTitle = title;
            movieCategory = category;

        }
    }
}
