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
        public List<Models.User> AllUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.User>("dbo.RetrieveUsers").ToList();
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
    }
}
