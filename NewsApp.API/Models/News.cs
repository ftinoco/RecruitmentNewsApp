using System;

namespace NewsApp.API.Models
{
    public class News
    {
        public long newsID { get; set; }

        public DateTime publishedDate { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public string imgURL { get; set; }
    } 
}