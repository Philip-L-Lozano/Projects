using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public partial class RootObject
    {
        public MovieReturn[] Search { get; set; }
        public int totalResults { get; set; }
        public string Response { get; set; }


    }
}
