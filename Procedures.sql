GO
CREATE DATABASE CIS5601;
GO
-- Here's a simple procedure fetching a single person, if the row exists.
CREATE PROCEDURE dbo.RetrieveUser
   @UserName NVARCHAR(32)
AS
SELECT U.UserName, U.FirstName,U.LastName, U.DateJoined,U.LastActiveDate, U.IsRemoved
FROM dbo.[User] U
WHERE U.UserName = @UserName;
GO
-- Here's a simple procedure fetching a single Game, if the row exists.
CREATE PROCEDURE dbo.RetrieveGame
   @GameName NVARCHAR(32)
AS
SELECT G.GameName,G.DeveloperName, G.GenreName, G.Price, G.ReleaseDate,G.IsRemoved
FROM dbo.Game G
WHERE G.GameName = @GameName;
GO
-- Here's a simple procedure fetching all genres
CREATE PROCEDURE dbo.RetrieveGenre
AS
SELECT *
FROM dbo.Genre G
GO
-- Here's a simple procedure fetching all genres
CREATE PROCEDURE dbo.RetrieveDeveloper
AS
SELECT *
FROM dbo.Developer D
GO
-- Here's a simple procedure fetching all games of type genre
CREATE PROCEDURE dbo.RetrieveGamesGenreFilter
	@GenreName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.GenreName = @GenreName
GO
-- Here's a simple procedure fetching all games of type genre
CREATE PROCEDURE dbo.RetrieveGamesDeveloperFilter
	@DeveloperName NVARCHAR(32)
AS
SELECT *
FROM dbo.Game G
WHERE G.DeveloperName = @DeveloperName
GO
-- Here's a simple procedure fetching all games of type genre
CREATE PROCEDURE dbo.RetrieveGamesLessThanFive
AS
SELECT *
FROM dbo.Game G
WHERE G.Price < 5
GO
-- Here's a simple procedure fetching all games of high to low
CREATE PROCEDURE dbo.RetrieveGamesHigh2Low
AS
SELECT *
FROM dbo.Game G
Order BY G.Price DESC
GO
-- Here's a simple procedure fetching all games of low to high
CREATE PROCEDURE dbo.RetrieveGamesLow2High
AS
SELECT *
FROM dbo.Game G
Order BY G.Price ASC
GO
-- Here's a simple procedure fetching a single person's library
CREATE PROCEDURE dbo.RetrieveLibrary
   @UserName NVARCHAR(32)
AS
SELECT L.GameName, L.PurchasedDate
FROM dbo.[Library] L
	INNER JOIN dbo.[User] U ON U.UserId = L.UserId
WHERE U.UserName = @UserName;
GO
-- Here's a simple procedure fetching a single person's library
CREATE PROCEDURE dbo.RetrieveReviews
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName;
GO
-- Here's a simple procedure fetching a single person's library
CREATE PROCEDURE dbo.RetrieveReviewsHighScore
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName
Order BY R.FiveStarScore DESC;
GO
-- Here's a simple procedure fetching a single person's library
CREATE PROCEDURE dbo.RetrieveReviewsLowScore
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName
Order BY R.FiveStarScore ASC;
GO
-- Here's a simple procedure fetching a single person's library
CREATE PROCEDURE dbo.RetrieveReviewsRecent
   @GameName NVARCHAR(32)
AS
SELECT R.[Description],R.FiveStarScore,R.DateAdded
FROM dbo.Review R
WHERE R.GameName = @GameName
Order BY R.DateAdded DESC;
GO
-- Here's a simple procedure fetching all games
CREATE PROCEDURE dbo.RetrieveGames
AS
SELECT *
FROM dbo.Game
GO
-- Here's a simple procedure fetching all users
CREATE PROCEDURE dbo.RetrieveUsers
AS
SELECT *
FROM dbo.[User]
GO
-- Here's a simple procedure create a single game
CREATE PROCEDURE dbo.CreateGame
   @GameName NVARCHAR(32), @DeveloperName NVARCHAR(32), @GenreName NVARCHAR(32), @Price INT,
   @ReleaseDate DATETIMEOFFSET, @IsRemoved INT
AS
INSERT INTO dbo.Game(GameName,DeveloperName,GenreName,Price,ReleaseDate,IsRemoved)
Values
	(@GameName,@DeveloperName,@GenreName,@Price,@ReleaseDate,@IsRemoved)
GO
-- Here's a simple procedure creating a single person
CREATE PROCEDURE dbo.CreateUser
   @UserName NVARCHAR(32), @FirstName NVARCHAR(32), @LastName NVARCHAR(32),
   @DateJoined DATETIMEOFFSET,@LastActiveDate DATETIMEOFFSET, @IsRemoved INT
AS
INSERT INTO dbo.[User](UserName,FirstName,LastName,DateJoined,LastActiveDate,IsRemoved)
Values
	(@UserName,@FirstName,@LastName,@DateJoined,@LastActiveDate,@IsRemoved)
GO
-- Here's a simple procedure creating a single library entry
CREATE PROCEDURE dbo.CreateLibrary
   @UserId NVARCHAR(32), @GameName NVARCHAR(32), @PurchasedDate DATETIMEOFFSET
AS
INSERT INTO dbo.[Library](UserId,GameName,PurchasedDate)
Values
	(@UserId,@GameName,@PurchasedDate)
GO
-- Here's a simple procedure creating a single library entry
CREATE PROCEDURE dbo.CreateReview
   @UserId Int, @GameName NVARCHAR(32), @Description NVARCHAR(150),
   @FiveStarScore INT, @DateAdded DATETIMEOFFSET
AS
INSERT INTO dbo.Review(UserId,GameName,[Description],FiveStarScore,DateAdded)
Values
	(@UserId,@GameName,@Description,@FiveStarScore,@DateAdded)
GO
-- Here's a simple procedure creating a single library entry
CREATE PROCEDURE dbo.CreateSession
   @UserId Int, @SessionStartTime DATETIMEOFFSET, @SessionEndTime DATETIMEOFFSET
AS
INSERT INTO dbo.Session(UserId,SessionStartTime,SessionEndTime)
Values
	(@UserId,@SessionStartTime,@SessionEndTime)
GO
