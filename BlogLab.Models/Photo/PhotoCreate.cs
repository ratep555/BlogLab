using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Models.Photo
{
    public class PhotoCreate
    {
        // this one matches the types in sql
        public string ImageUrl { get; set; }

        public string PublicId { get; set; }

        public string Description { get; set; }
    }
}
