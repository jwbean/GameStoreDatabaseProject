using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public string GameName { get; set; }
        public DateTimeOffset SessionStartTime { get; set; }
        public DateTimeOffset SessionEndTime { get; set; }

    }
    public class AverageHours
    {
        public string GameName { get; set; }
        public int AverageHoursPlayed { get; set; }
    }
    public class TopPlayers
    {
        public string UserName { get; set; }
        public int TotalHours { get; set; }
    }
}
