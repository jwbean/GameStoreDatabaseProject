using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject.Models
{
    public class Game
    {
        public string GameName { get; set; }
        public string DeveloperName { get; set; }
        public string GenreName { get; set; }
        public int Price { get; set; }
        public DateTimeOffset ReleasedDate { get; set; }
        public bool IsRemoved { get; set; }

    }
}
