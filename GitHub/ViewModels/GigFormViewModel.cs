using System;
using GitHub.Models;
using System.Collections.Generic;

namespace GitHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        // we need the list of genre from the database inorder to use as the second argument in dropdownlist
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime
        {
            get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }

        }
    }
}