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
        public List<Models.Game> GetGame(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGame @GameName", new { GameName = gameName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesGenre(string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesGenreFilter @GenreName", new { GenreName = genreName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesDeveloper(string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesDeveloperFilter @DeveloperName", new { DeveloperName = developerName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesCheep()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLessThanFive").ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesHigh2Low()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesHigh2Low").ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesLow2High()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLow2High").ToList();
                return output;
            }
        }
        public List<Models.Genre> GetGenres()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Genre>("dbo.RetrieveGenre").ToList();
                return output;
            }
        }
        public List<Models.Developer> GetDeveloper ()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Developer>("dbo.RetrieveDeveloper").ToList();
                return output;
            }
        }
        public List<Models.Game> AllGames()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGames").ToList();
                return output;
            }
        }
        public void CreateGame(string gameName, string developerName, string genre, int price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.Game> game = new List<Models.Game>();
                game.Add(new Models.Game { GameName = gameName, DeveloperName = developerName, GenreName = genre, Price = price, ReleaseDate = DateTimeOffset.Now, IsRemoved = true });
                connection.Execute("dbo.CreateGame @GameName, @DeveloperName, @GenreName, @Price, @ReleasedDate, @IsRemoved", game);

            }
        }
    }
}
