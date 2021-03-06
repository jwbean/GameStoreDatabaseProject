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
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsRemoved { get; set; }

    }
    public class FirstMonthSales
    {
        public string GameName { get; set; }
        public int GamesSold { get; set; }
        public int TotalSales { get; set; }
    }
    public class BestDayOFSales
    {
        public DateTime PurchasedDate { get; set; }
        public int GamesSold { get; set; }
        public int TotalSales { get; set; }
    }

}
