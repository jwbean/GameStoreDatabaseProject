USE CIS560;
GO
-- Here's a simple procedure fetching a single person, if the row exists.
CREATE OR ALTER PROCEDURE dbo.RetrieveUser
   @UserName NVARCHAR(32)
AS
SELECT U.UserName, U.FirstName,U.LastName, U.DateJoined,U.LastActiveDate, U.IsRemoved
FROM dbo.[User] U
WHERE U.UserName = @UserName;
GO
-- Here's a simple procedure fetching a single Game, if the row exists.
CREATE OR ALTER PROCEDURE dbo.RetrieveGame
   @GameName NVARCHAR(32)
AS
SELECT G.GameName,G.DeveloperName, G.GenreName, G.Price, G.ReleaseDate,G.IsRemoved
FROM dbo.Game G
WHERE G.GameName = @GameName;
GO
-- Here's a simple procedure fetching all genres
CREATE OR ALTER PROCEDURE dbo.RetrieveGenre
AS
SELECT *
FROM dbo.Genre G
GO
-- Here's a simple procedure fetching all genres
CREATE OR ALTER PROCEDURE dbo.RetrieveDeveloper
AS
SELECT *
FROM dbo.Developer D
GO
-- Here's a simple procedure fetching all games of type genre
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesGenreFilter
	@GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName
GO
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesGenreDeveloperFilter
	@GenreName NVARCHAR(32), @DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName AND G.DeveloperName = @DeveloperName
GO
-- Here's a simple procedure fetching all games of type genre
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesDeveloperFilter
	@DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.DeveloperName = @DeveloperName
GO
-- Here's a simple procedure fetching all games of type genre
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLessThanFive
AS
SELECT *
FROM dbo.Game G
WHERE G.Price < 5
GO
-- Here's a simple procedure fetching all games of type genre
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLessThanFiveGenre
	@GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.Price < 5 AND G.GenreName = @GenreName
GO
-- Here's a simple procedure fetching all games of type genre
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLessThanFiveDeveloper
	@DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.Price < 5 AND G.DeveloperName = @DeveloperName
GO
-- Here's a simple procedure fetching all games of type genre
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLessThanFiveDeveloperGenre
	@DeveloperName NVARCHAR(32), @GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.Price < 5 AND G.DeveloperName = @DeveloperName AND G.GenreName = @GenreName
GO
-- Here's a simple procedure fetching all games of high to low
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesHigh2Low
AS
SELECT *
FROM dbo.Game G
Order BY G.Price DESC
GO
-- Here's a simple procedure fetching all games of high to low
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesHigh2LowGenre
	@GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName
Order BY G.Price DESC
GO
-- Here's a simple procedure fetching all games of high to low
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesHigh2LowDeveloper
	@DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.DeveloperName = @DeveloperName
Order BY G.Price DESC
GO
-- Here's a simple procedure fetching all games of high to low
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesHigh2LowGenreDeveloper
	@GenreName NVARCHAR(32), @DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName AND G.DeveloperName = @DeveloperName
Order BY G.Price DESC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLow2High
AS
SELECT *
FROM dbo.Game G
Order BY G.Price ASC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLow2HighGenre
	@GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName
Order BY G.Price ASC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLow2HighDeveloper
	@DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.DeveloperName = @DeveloperName
Order BY G.Price ASC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesLow2HighGenreDeveloper
	@GenreName NVARCHAR(32), @DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName AND G.DeveloperName = @DeveloperName
Order BY G.Price ASC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesReleaseDate
AS
SELECT *
FROM dbo.Game G
Order BY G.ReleaseDate DESC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesReleaseDateGenre
	@GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName
Order BY G.ReleaseDate DESC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesReleaseDateDeveloper
	@DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.DeveloperName = @DeveloperName
Order BY G.ReleaseDate DESC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE OR ALTER PROCEDURE dbo.RetrieveGamesReleaseDateGenreDeveloper
	@GenreName NVARCHAR(32), @DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName AND G.DeveloperName = @DeveloperName
Order BY G.ReleaseDate DESC
GO
-- Here's a simple procedure fetching a single person's library
CREATE OR ALTER PROCEDURE dbo.RetrieveLibrary
   @UserName NVARCHAR(32)
AS
SELECT L.GameName, L.PurchasedDate
FROM dbo.[Library] L
	INNER JOIN dbo.[User] U ON U.UserId = L.UserId
WHERE U.UserName = @UserName;
GO
-- Here's a simple procedure fetching a single person's library
CREATE OR ALTER PROCEDURE dbo.RetrieveReviews
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName;
GO
-- Here's a simple procedure fetching a single person's library
CREATE OR ALTER PROCEDURE dbo.RetrieveReviewsHighScore
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName
Order BY R.FiveStarScore DESC;
GO
-- Here's a simple procedure fetching a single person's library
CREATE OR ALTER PROCEDURE dbo.RetrieveReviewsLowScore
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName
Order BY R.FiveStarScore ASC;
GO
-- Here's a simple procedure fetching a single person's library
CREATE OR ALTER PROCEDURE dbo.RetrieveReviewsRecent
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName
Order BY R.DateAdded DESC;
GO
-- Here's a simple procedure fetching a single person's library
CREATE OR ALTER PROCEDURE dbo.RetrieveReviewUser
   @GameName NVARCHAR(32), @UserId INT
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName AND R.UserId = @UserId
GO
-- Here's a simple procedure fetching all games
CREATE OR ALTER PROCEDURE dbo.RetrieveGames
AS
SELECT *
FROM dbo.Game
GO
-- Here's a simple procedure fetching all users
CREATE OR ALTER PROCEDURE dbo.RetrieveUsers
AS
SELECT *
FROM dbo.[User]
GO
-- Here's a simple procedure create a single game
CREATE OR ALTER PROCEDURE dbo.CreateGame
   @GameName NVARCHAR(32), @DeveloperName NVARCHAR(32), @GenreName NVARCHAR(32), @Price DECIMAL(10,2),
   @ReleaseDate DATE, @IsRemoved INT
AS
INSERT INTO dbo.Game(GameName,DeveloperName,GenreName,Price,ReleaseDate,IsRemoved)
Values
	(@GameName,@DeveloperName,@GenreName,@Price,@ReleaseDate,@IsRemoved)
GO
-- Here's a simple procedure creating a single person
CREATE OR ALTER PROCEDURE dbo.CreateUser
   @UserName NVARCHAR(32), @FirstName NVARCHAR(32), @LastName NVARCHAR(32),
   @DateJoined DATE,@LastActiveDate DATE, @IsRemoved INT
AS
INSERT INTO dbo.[User](UserName,FirstName,LastName,DateJoined,LastActiveDate,IsRemoved)
Values
	(@UserName,@FirstName,@LastName,@DateJoined,@LastActiveDate,@IsRemoved)
GO
-- Here's a simple procedure creating a single library entry
CREATE OR ALTER PROCEDURE dbo.CreateLibrary
   @UserId NVARCHAR(32), @GameName NVARCHAR(32), @PurchasedDate DATE
AS
INSERT INTO dbo.[Library](UserId,GameName,PurchasedDate)
Values
	(@UserId,@GameName,@PurchasedDate)
GO
-- Here's a simple procedure creating a single library entry
CREATE OR ALTER PROCEDURE dbo.CreateReview
   @UserId Int, @GameName NVARCHAR(32), @Description NVARCHAR(150),
   @FiveStarScore INT, @DateAdded DATE
AS
INSERT INTO dbo.Review(UserId,GameName,[Description],FiveStarScore,DateAdded)
Values
	(@UserId,@GameName,@Description,@FiveStarScore,@DateAdded)
GO
-- Here's a simple procedure creating a single library entry
CREATE OR ALTER PROCEDURE dbo.CreateSession
   @UserId Int, @GameName NVARCHAR(32), @SessionStartTime DATETIMEOFFSET, @SessionEndTime DATETIMEOFFSET
AS
INSERT INTO dbo.[Session](UserId,GameName,SessionStartTime,SessionEndTime)
Values
	(@UserId,@GameName,@SessionStartTime,@SessionEndTime)
GO
CREATE OR ALTER PROCEDURE dbo.AverageHoursPlayed
AS
WITH SessionsCTE(UserId, SessionTime, SessionId, GameName) AS
    (
        SELECT S.UserId, DATEDIFF(HOUR, S.SessionStartTime,S.SessionEndTime ) AS SessionTime, S.SessionId, S.GameName
        FROM [Session] S
        GROUP BY S.UserId, S.SessionId, S.GameName, S.SessionStartTime, S.SessionEndTime
    )
SELECT SC.GameName, 
    SUM(SC.SessionTime)/COUNT(DISTINCT SC.UserId) AS AverageHoursPlayed 
FROM SessionsCTE SC
GROUP BY SC.GameName
GO
CREATE OR ALTER PROCEDURE dbo.FirstMonthSales
AS
SELECT G.GameName, COUNT(DISTINCT L.UserId) AS GamesSold, SUM(G.Price) AS TotalSales
FROM dbo.[Game] G
INNER JOIN Library L ON G.GameName = L.GameName
WHERE L.PurchasedDate <= DATEADD(MONTH, 1, G.ReleaseDate)
GROUP BY G.GameName
GO
CREATE OR ALTER PROCEDURE dbo.ActiveUsers
 @FirstDate DATE, @LastDate DATE
AS
SELECT COUNT(*) AS ActiveUsers
FROM dbo.[USER] U
WHERE LastActiveDate BETWEEN @FirstDate AND @LastDate
GO
CREATE OR ALTER PROCEDURE dbo.BestDayOFSales
AS
SELECT L.PurchasedDate AS PurchasedDate, COUNT(L.PurchasedDate) AS GamesSold, SUM(G.Price) AS TotalSales, 
RANK() OVER(ORDER BY SUM(G.Price) DESC) AS SalesRanking
FROM dbo.Game G
INNER JOIN Library L ON G.GameName = L.GameName
GROUP BY L.PurchasedDate
GO
CREATE OR ALTER PROCEDURE dbo.EditUser
	@Username NVARCHAR(32), @FirstName NVARCHAR(32),@LastName NVARCHAR(32)
AS
UPDATE dbo.[User]
SET
	FirstName = @FirstName,
	LastName = @LastName
WHERE UserName = @Username
GO
CREATE OR ALTER PROCEDURE dbo.EditGame
	@GameName NVARCHAR(32), @Price DECIMAL(10,2)
AS
UPDATE dbo.Game
SET
	Price = @Price
WHERE GameName = @GameName
GO
CREATE OR ALTER PROCEDURE dbo.UpdateLastActive
	@UserId INT, @LastActiveDate DATE
AS
UPDATE dbo.[User]
SET
	LastActiveDate = @LastActiveDate
WHERE UserId = @UserId
GO
CREATE OR ALTER PROCEDURE dbo.NewUsers
AS
SELECT COUNT(*) AS NewUsers
FROM dbo.[User] U
WHERE U.DateJoined > (DATEADD(MONTH, DATEDIFF(MONTH, 0, CURRENT_TIMESTAMP) - 1, 0))

GO
CREATE OR ALTER PROCEDURE dbo.TopSpender
AS
SELECT U.UserName, SUM(G.Price) 
    AS TotalSpent
FROM [Library] L
    INNER JOIN dbo.Game G ON G.GameName = L.GameName
	INNER JOIN dbo.[User] U ON U.UserId = L.UserId
GROUP BY U.UserName
ORDER BY TotalSpent DESC
GO
CREATE OR ALTER PROCEDURE dbo.TopPlayers
	@GameName NVARCHAR(32)
AS
WITH SessionsCTE(UserId, SessionTime, SessionId, GameName) AS
    (
        SELECT S.UserId, DATEDIFF(HOUR, S.SessionStartTime,S.SessionEndTime ) AS SessionTime, S.SessionId, S.GameName
        FROM [Session] S
        GROUP BY S.UserId, S.SessionId, S.GameName, S.SessionStartTime, S.SessionEndTime
    )
SELECT U.UserName, 
    SUM(SC.SessionTime) AS TotalHours
FROM SessionsCTE SC
INNER JOIN dbo.[User] U ON U.UserId = SC.UserId
WHERE SC.GameName = @GameName
GROUP BY U.UserName
GO