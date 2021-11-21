Use CIS560;
CREATE TABLE dbo.Developer(
DeveloperName NVARCHAR(32) NOT NULL PRIMARY KEY,
[Description] NVARCHAR(150) NOT NULL
)
CREATE TABLE dbo.Genre(
GenreName NVARCHAR(32) NOT NULL PRIMARY KEY,
[Description] NVARCHAR(150) NOT NULL
)
CREATE TABLE dbo.[User](
UserId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
UserName NVARCHAR(32) NOT NULL,
FirstName NVARCHAR(32) NOT NULL,
LastName NVARCHAR(32) NOT NULL,
DateJoined DATE NOT NULL,
LastActiveDate DATE NOT NULL,
IsRemoved INT NOT NULL CHECK(IsRemoved=1 OR IsRemoved = 0)
UNIQUE(UserName)
)
CREATE TABLE dbo.Game(
GameName NVARCHAR(32) NOT NULL PRIMARY KEY,
DeveloperName NVARCHAR(32) NOT NULL FOREIGN KEY
REFERENCES dbo.Developer(DeveloperName),
GenreName NVARCHAR(32) NOT NULL FOREIGN KEY
REFERENCES dbo.Genre(GenreName),
Price DECIMAL(10,2) NOT NULL,
ReleaseDate DATE NOT NULL,
IsRemoved INT NOT NULL CHECK(IsRemoved=1 OR IsRemoved = 0)
)
CREATE TABLE dbo.[Library](
UserId INT NOT NULL FOREIGN KEY
REFERENCES dbo.[User](UserId),
GameName NVARCHAR(32) NOT NULL FOREIGN KEY
REFERENCES dbo.Game(GameName),
PurchasedDate DATE NOT NULL
PRIMARY KEY(UserId,GameName)
)
CREATE TABLE dbo.Review(
UserId INT NOT NULL FOREIGN KEY
REFERENCES dbo.[User](UserId),
GameName NVARCHAR(32) NOT NULL FOREIGN KEY
REFERENCES dbo.Game(GameName),
[Description] NVARCHAR(150) NOT NULL,
FiveStarScore INT NOT NULL CHECK(FiveStarScore>-1 AND FiveStarScore<6),
DateAdded DATE NOT NULL
PRIMARY KEY(UserId,GameName)
)
CREATE TABLE dbo.[Session](
SessionId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
UserId INT NOT NULL,
GameName NVARCHAR(32) NOT NULL, 
SessionStartTime DATETIMEOFFSET NOT NULL,
SessionEndTime DATETIMEOFFSET NOT NULL,
CONSTRAINT Lib
FOREIGN KEY (UserId,GameName)
	REFERENCES dbo.[Library](UserId,GameName)
)
GO
INSERT INTO dbo.[User](UserName,FirstName,LastName,DateJoined,LastActiveDate,IsRemoved)
VALUES
  (N'zCannon',N'Zephr',N'Cannon','2018-10-31','2020-02-05',1),
  (N'bYork',N'Britanney',N'York','2019-01-24','2021-11-09',1),
  (N'kJackson',N'Kyle',N'Jackson','2020-09-20','2021-03-08',1),
  (N'iArmStrong',N'Iola',N'Armstrong','2021-11-08','2021-11-15',1),
  (N'kYates',N'Kenneth',N'Yates','2021-03-08','2021-11-08',1);
INSERT INTO dbo.Developer(DeveloperName,[Description])
VALUES
  (N'Ac Eleifend Vitae Inc.',N'molestie tellus. Aenean egestas hendrerit neque. In ornare'),
  (N'Sit Incorporated',N'Nunc sed orci lobortis augue scelerisque mollis. Phasellus'),
  (N'At Ltd',N'Curabitur egestas nunc sed libero. Proin sed turpis'),
  (N'Amet Faucibus Ltd',N'ridiculus mus. Proin vel nisl. Quisque fringilla euismod'),
  (N'Varius Nam Institute',N'et malesuada fames ac turpis egestas. Fusce aliquet');
INSERT INTO dbo.Genre(GenreName,[Description])
Values
	(N'Horror',N'ullamcorper, nisl arcu iaculis enim, sit amet'),
	(N'Adventure',N'montes, nascetur ridiculus mus. Proin vel arcu'),
	(N'Platformer',N'pede nec ante blandit viverra. Donec tempus'),
	(N'Shooter',N'lobortis augue scelerisque mollis. Phasellus libero mauris'),
	(N'Multiplayer',N'dui nec urna suscipit nonummy. Fusce fermentum');
INSERT INTO dbo.Game(GameName,DeveloperName,GenreName,Price,ReleaseDate,IsRemoved)
VALUES
	(N'Blockstar',N'Ac Eleifend Vitae Inc.',N'Horror',3,'2019-11-27',1),
	(N'Presidential',N'Ac Eleifend Vitae Inc.',N'Adventure',10,'2019-06-20',1),
	(N'Unpleasant Tennis',N'Sit Incorporated',N'Multiplayer',15,'2021-03-10',1),
	(N'Blood Carnage',N'Sit Incorporated',N'Shooter',8,'2020-09-29',1),
	(N'Geofight',N'At Ltd',N'Platformer',4,'2019-11-19',1),
	(N'Radioactive',N'At Ltd',N'Platformer',12,'2021-06-03',1),
	(N'Cloud Premonition',N'Amet Faucibus Ltd',N'Horror',1,'2020-01-28',1),
	(N'Fun Freak',N'Amet Faucibus Ltd',N'Horror',1,'2020-12-28',1),
	(N'Hellheart',N'Varius Nam Institute',N'Shooter',12,'2018-03-21',1),
	(N'Castlezone',N'Varius Nam Institute',N'Shooter',12,'2019-03-26',1);
INSERT dbo.[Library](UserId,GameName,PurchasedDate)
SELECT U.UserId, S.GameName, S.PurchasedDate
FROM
	(
	VALUES
	(N'zCannon',N'Blockstar','2019-11-29'),
	(N'zCannon',N'Presidential','2019-07-27'),
	(N'zCannon',N'Unpleasant Tennis','2021-03-11'),
	(N'bYork',N'Blood Carnage','2020-09-29'),
	(N'bYork',N'Geofight','2019-12-22'),
	(N'bYork',N'Radioactive','2021-06-27'),
	(N'kJackson',N'Cloud Premonition','2020-11-28'),
	(N'kJackson',N'Fun Freak','2021-02-28'),
	(N'kJackson',N'Hellheart','2020-03-21'),
	(N'kJackson',N'Castlezone','2019-12-26'),
	(N'iArmStrong',N'Unpleasant Tennis','2021-03-11'),
	(N'iArmStrong',N'Blood Carnage','2020-09-29'),
	(N'iArmStrong',N'Geofight','2019-12-22'),
	(N'kYates',N'Hellheart','2020-03-21'),
	(N'kYates',N'Castlezone','2019-12-26'),
	(N'kYates',N'Unpleasant Tennis','2021-03-11')
	) S(UserName,GameName,PurchasedDate)
	INNER JOIN dbo.[User] U ON U.UserName = S.UserName;
INSERT dbo.Review(UserId,GameName,[Description],FiveStarScore,DateAdded)
SELECT U.UserId, S.GameName, S.[Description], S.FiveStarScore, S.DateAdded
FROM 
(
VALUES
	(N'zCannon',N'Blockstar',N'purus mauris a nunc. In at pede. Cras vulputate velit',5,'2019-12-02'),
	(N'zCannon',N'Presidential',N'vehicula aliquet',3,'2019-07-27 08:10:05'),
	(N'zCannon',N'Unpleasant Tennis',N'purus mauris a nunc. In at pede. Cras vulputate velit',2,'2021-03-15'),
	(N'bYork',N'Blood Carnage',N'vehicula aliquet',3,'2021-09-29'),
	(N'bYork',N'Geofight',N'purus mauris a nunc. In at pede. Cras vulputate velit',4,'2019-12-22'),
	(N'bYork',N'Radioactive',N'et magnis dis',5,'2021-06-27'),
	(N'kJackson',N'Cloud Premonition',N'et magnis dis',5,'2020-12-28'),
	(N'kJackson',N'Fun Freak',N'In scelerisque scelerisque dui. Suspendisse ac metus',1,'2021-11-05'),
	(N'kJackson',N'Hellheart',N'at sem',1,'2020-06-21'),
	(N'kJackson',N'Castlezone',N'Aliquam nec enim. Nunc',3,'2020-12-26'),
	(N'iArmStrong',N'Unpleasant Tennis',N'Aliquam nec enim. Nunc',2,'2021-03-15'),
	(N'iArmStrong',N'Blood Carnage',N'at sem',4,'2020-11-29 11:19:20'),
	(N'iArmStrong',N'Geofight',N'ultricies dignissim lacus. Aliquam rutrum lorem ac risus.',5,'2020-12-22'),
	(N'kYates',N'Hellheart',N'In scelerisque scelerisque dui. Suspendisse ac metus',2,'2021-03-21'),
	(N'kYates',N'Castlezone',N'vehicula aliquet',3,'2020-12-26 08:53:08'),
	(N'kYates',N'Unpleasant Tennis',N'ultricies dignissim lacus. Aliquam rutrum lorem ac risus.',2,'2021-04-11')
	) S(UserName, GameName, [Description], FiveStarScore, DateAdded)
	INNER JOIN dbo.[User] U ON U.UserName = S.UserName;
INSERT dbo.[Session](UserId,GameName,SessionStartTime,SessionEndTime)
SELECT U.UserId, S.GameName, S.SessionStartTime,S.SessionEndTime
FROM
(
VALUES
	(N'zCannon',N'Blockstar','2019-12-02 18:47:43','2019-12-02 20:47:43'),
	(N'zCannon',N'Presidential','2019-07-27 08:10:05','2019-07-27 10:10:05'),
	(N'zCannon',N'Unpleasant Tennis','2021-03-15 21:22:54','2021-03-15 22:22:54'),
	(N'bYork',N'Blood Carnage','2021-09-29 11:19:20','2021-09-29 18:19:20'),
	(N'bYork',N'Geofight','2019-12-22 11:18:50','2019-12-22 15:18:50'),
	(N'bYork',N'Radioactive','2021-06-27 01:21:32','2021-06-27 02:21:32'),
	(N'kJackson',N'Cloud Premonition','2020-12-28 01:00:52','2020-12-28 03:00:52'),
	(N'kJackson',N'Fun Freak','2021-11-05 01:00:52','2021-11-05 06:00:52'),
	(N'kJackson',N'Hellheart','2020-06-21 16:36:57','2020-06-21 19:36:57'),
	(N'kJackson',N'Castlezone','2020-12-26 08:53:08','2020-12-26 15:53:08'),
	(N'iArmStrong',N'Unpleasant Tennis','2021-03-15 21:22:54','2021-03-15 22:22:54'),
	(N'iArmStrong',N'Blood Carnage','2020-11-29 11:19:20','2020-11-29 12:19:20'),
	(N'iArmStrong',N'Geofight','2020-12-22 11:18:50','2020-12-22 13:18:50'),
	(N'kYates',N'Hellheart','2021-03-21 16:36:57','2021-03-21 17:36:57'),
	(N'kYates',N'Castlezone','2020-12-26 08:53:08','2020-12-26 18:53:08'),
	(N'kYates',N'Unpleasant Tennis','2021-04-11 21:22:54','2021-04-11 22:22:54')
) S(UserName, GameName, SessionStartTime,SessionEndTime)
INNER JOIN dbo.[User] U ON U.UserName = S.UserName;