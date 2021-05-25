using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        public string Type { get; set; }
        public string Title { get; set;}
        public int Year { get; set;}
        public float Weight { get; set;}
        public DateTime TimePublish { get; set; }
    }
}
