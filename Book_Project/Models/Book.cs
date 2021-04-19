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
        //This is the primary key
        public int Book_ID { get; set; }
         //This is the variable to store the book title
        public string Book_Title { get; set; }
         //This is the variable to store the author
        public string Author { get; set; }
         //This is the variable to store the publisher
        public string Publisher { get; set; }
         //This is the variable to store the year of publish
        public int Year_of_publish { get; set; }
    }
}
