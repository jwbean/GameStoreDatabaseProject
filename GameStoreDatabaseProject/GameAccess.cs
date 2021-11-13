using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject
{
    public class GameAccess
    {
        public List<Models.Game> GetGames(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGame @GameName", new { GameName = gameName }).ToList();
                return output;
            }
        }
        public void CreateGame(string gameName, string developerName, string genre, int price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.Game> game = new List<Models.Game>();
                game.Add(new Models.Game { GameName = gameName, DeveloperName = developerName, GenreName = genre, Price = price, ReleasedDate = DateTimeOffset.Now, IsRemoved = true });
                connection.Execute("dbo.CreateGame @GameName, @DeveloperName, @GenreName, @Price, @ReleasedDate, @IsRemoved", game);

            }
        }
    }
}
