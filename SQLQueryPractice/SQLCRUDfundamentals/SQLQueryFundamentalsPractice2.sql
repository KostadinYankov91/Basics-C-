CREATE TABLE [Minions](
[Id] INT NOT NULL,
[Name] NVARCHAR(50) NOT NULL,
[Age] INT NULL)

ALTER TABLE [Minions]
ADD CONSTRAINT PK_MinionsId PRIMARY KEY (Id);

INSERT INTO [Minions]
VALUES (1, 'Kevin', 15),
(2, 'Bob', 22),
(3, 'Stuart', NULL)	

SELECT * FROM Minions

--THE RIGHT WAY TO SET PRIMARY KEY
CREATE TABLE [Towns](
	[Id] INT PRIMARY KEY  NOT NULL,
	[Name] NVARCHAR(50) NOT NULL)



ALTER TABLE [Minions]
ADD CONSTRAINT [FK_MinionsTownId] FOREIGN KEY (Id) REFERENCES [Towns] ([Id])
ALTER TABLE [Minions]
ADD [TownId] INT  

INSERT INTO [Towns]([Id], [Name]) VALUES 
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT INTO [Minions]([Id], [Name], [Age], [TownId]) VALUES 
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)

SELECT * FROM Minions

CREATE TABLE [Users]
(
[Id] BIGINT PRIMARY KEY IDENTITY,
[Username] VARCHAR(30) UNIQUE NOT NULL,
[Password] VARCHAR(26) NOT NULL,
[ProfilePicture] VARBINARY(MAX),
CHECK (DATALENGTH([ProfilePicture]) <= 900000),
[LastLoginTime] DATETIME2,
[IsDeleted] BIT NOT NULL
)



INSERT INTO Users([Id],[Username],[Password],[ProfilePicture],[LastLoginTime], [IsDeleted])VALUES

