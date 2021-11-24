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
        public List<Models.Game> GetGamesDeveloperGenre(string developerName, string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesGenreDeveloperFilter @GenreName, @DeveloperName", new { GenreName = genreName, DeveloperName = developerName }).ToList();
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
        public List<Models.Game> GetGamesCheepGenre(string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLessThanFiveGenre @GenreName", new { GenreName = genreName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesCheepDeveloper(string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLessThanFiveDeveloper @DevleoperName", new { DevleoperName = developerName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesCheepGenreDeveloper(string genreName, string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLessThanFiveDeveloperGenre @DevleoperName, @GenreName", new { DevleoperName = developerName, GenreName = genreName }).ToList();
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
        public List<Models.Game> GetGamesHigh2LowGenre(string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesHigh2LowGenre @GenreName", new { GenreName = genreName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesHigh2LowDeveloper(string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesHigh2LowDeveloper @DeveloperName", new { DeveloperName = developerName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesHigh2LowGenreDeveloper(string developerName, string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesHigh2LowGenreDeveloper @GenreName, @DeveloperName", new { GenreName = genreName, DeveloperName = developerName }).ToList();
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
        public List<Models.Game> GetGamesLow2HighGenre(string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLow2HighGenre @GenreName", new { GenreName = genreName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesLow2HighDeveloper(string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLow2HighDeveloper @DeveloperName", new { DeveloperName = developerName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesLow2HighDeveloperGenre(string developerName, string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesLow2HighGenreDeveloper @GenreName, @DeveloperName", new { GenreName = genreName, DeveloperName = developerName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesReleaseDate()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesReleaseDate").ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesReleaseDateGenre(string genreName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesReleaseDateGenre @GenreName", new { GenreName = genreName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesReleaseDateDeveloper(string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesReleaseDateDeveloper @DeveloperName", new { DeveloperName = developerName }).ToList();
                return output;
            }
        }
        public List<Models.Game> GetGamesReleaseDateGenreDeveloper(string genreName, string developerName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Game>("dbo.RetrieveGamesReleaseDateGenreDeveloper @GenreName, @DeveloperName", new { GenreName = genreName, DeveloperName = developerName }).ToList();
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
        public List<Models.FirstMonthSales> FirstMonthSales()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.FirstMonthSales>("dbo.FirstMonthSales").ToList();
                return output;
            }
        }
        public List<Models.BestDayOFSales> BestDayofSales()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.BestDayOFSales>("dbo.BestDayOFSales").ToList();
                return output;
            }
        }
        public List<Models.TopPlayers> TopPlayers(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.TopPlayers>("dbo.TopPlayers @GameName",new { GameName = gameName }).ToList();
                return output;
            }
        }
        public void CreateGame(string gameName, string developerName, string genre, double price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.Game> game = new List<Models.Game>();
                game.Add(new Models.Game { GameName = gameName, DeveloperName = developerName, GenreName = genre, Price = price, ReleaseDate = DateTime.Now, IsRemoved = true });
                connection.Execute("dbo.CreateGame @GameName, @DeveloperName, @GenreName, @Price, @ReleaseDate, @IsRemoved", game);

            }
        }
        public void EditGame(string gameName, double price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                connection.Execute("dbo.EditGame @GameName,@Price", new { GameName = gameName, Price = price });

            }
        }

    }
}
