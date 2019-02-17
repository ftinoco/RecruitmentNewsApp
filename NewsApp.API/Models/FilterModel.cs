using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.API.Models
{
    public class FilterModel
    {
        public string strFilter { get; set; }

        public DateTime? startDate { get; set; }

        public DateTime? endDate { get; set; }
    }
}