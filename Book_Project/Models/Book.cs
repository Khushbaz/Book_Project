using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Project.Models
{
    public class Book
    {
        [Key]
        public int Book_ID { get; set; }
        public string Book_Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year_of_publish { get; set; }
    }
}
