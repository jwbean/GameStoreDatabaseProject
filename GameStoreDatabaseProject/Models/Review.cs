using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject.Models
{
    public class Review
    {
        public int UserId { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public int FiveStarScore { get; set; }
        public DateTimeOffset DateAdded { get; set; }
    }
}
