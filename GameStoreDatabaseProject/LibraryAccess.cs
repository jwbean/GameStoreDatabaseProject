using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject
{
    public class LibraryAccess
    {
        public List<Models.Library> GetLibrary(string userName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                var output = connection.Query<Models.Library>("dbo.RetrieveLibrary @UserName", new { UserName = userName }).ToList();
                return output;
            }
        }
        public void CreateLibrary(int userId, string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Connection.CnnVal("Database")))
            {
                List<Models.Library> library = new List<Models.Library>();
                library.Add(new Models.Library { UserId = userId, GameName = gameName, PurchasedDate = DateTimeOffset.Now});
                connection.Execute("dbo.CreateLibrary @UserId, @GameName, @PurchasedDate", library);
            }
        }
    }
}
