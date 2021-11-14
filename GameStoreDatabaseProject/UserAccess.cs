using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace GameStoreDatabaseProject
{
    public class UserAccess
    {
        public List<Models.User> GetUser(string userName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.User>("dbo.RetrieveUser @UserName", new { UserName = userName }).ToList();
                return output;
            }
        }
        public List<Models.Review> GetReviews(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Review>("dbo.RetrieveReviews @GameName", new { GameName = gameName }).ToList();
                return output;
            }
        }
        public List<Models.Review> GetReviewsHigh(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Review>("dbo.RetrieveReviewsHighScore @GameName", new { GameName = gameName }).ToList();
                return output;
            }
        }
        public List<Models.Review> GetReviewsLow(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Review>("dbo.RetrieveReviewsLowScore @GameName", new { GameName = gameName }).ToList();
                return output;
            }
        }
        public List<Models.Review> GetReviewsRecent(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Review>("dbo.RetrieveReviewsRecent @GameName", new { GameName = gameName }).ToList();
                return output;
            }
        }
        public List<Models.Review> GetUserReviews(string gameName, int userId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Review>("dbo.RetrieveReviewUser @GameName, @UserId", new { GameName = gameName, UserId = userId }).ToList();
                return output;
            }
        }
        public List<Models.User> AllUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.User>("dbo.RetrieveUsers").ToList();
                return output;
            }
        }
        public List<Models.TopSpender> TopSpender()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.TopSpender>("dbo.TopSpender").ToList();
                return output;
            }
        }
        public void CreateUser(string userName, string lastName,string fristName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.User> user = new List<Models.User>();
                user.Add(new Models.User { UserName = userName, LastName = lastName, FirstName = fristName, DateJoined = DateTimeOffset.Now, LastActiveDate = DateTimeOffset.Now,IsRemoved=true });
                connection.Execute("dbo.CreateUser @UserName, @FirstName, @LastName, @DateJoined, @LastActiveDate, @IsRemoved", user);
                
            }
        }
        public void CreateReview(int userId, string gameName, string description, int score)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.Review> review = new List<Models.Review>();
                review.Add(new Models.Review { UserId = userId, GameName = gameName, Description = description, FiveStarScore = score, DateAdded = DateTimeOffset.Now});
                connection.Execute("dbo.CreateReview @UserId, @GameName, @Description, @FiveStarScore, @DateAdded", review);

            }
        }
        public void CreateSession(int userId, string gameName, int hours)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.Session> session = new List<Models.Session>();
                session.Add(new Models.Session { UserId = userId, GameName = gameName, SessionStartTime = DateTimeOffset.Now, SessionEndTime = DateTimeOffset.Now.AddHours(hours) });
                connection.Execute("dbo.CreateSession @UserId,@GameName, @SessionStartTime, @SessionEndTime", session);

            }
        }
        public List<Models.AverageHours> AverageHoursPlayed()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.AverageHours>("dbo.AverageHoursPlayed").ToList();
                return output;

            }
        }
        public List<Models.ActiveUser> ActiveUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.ActiveUser>("dbo.ActiveUsers @FirstDate, @LastDate",new { FirstDate = DateTimeOffset.Now.AddDays(-14),LastDate = DateTimeOffset.Now}).ToList();
                return output;

            }
        }
        public void UpdateLastActive(int userId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                connection.Execute("dbo.UpdateActiveUser @UserId,@LastActiveDate", new { UserId = userId, LastActiveDate = DateTimeOffset.Now });

            }
        }
        public void EditUser(string userName,string firstName, string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                connection.Execute("dbo.EditUser @UserName,@FirstName,@LastName", new { UserName = userName, FirstName = firstName, LastName = lastName });

            }
        }
    }
}
