using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Blog
{
    // T means it can take any type into class, znao si:)
    public class PagedResults<T>
    {
        public IEnumerable<T> Items { get; set; }

        public int TotalCount { get; set; }
    }
}
