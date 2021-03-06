/*
   Tuesday, January 17, 20062:30:24 AM
   User: 
   Server: andrews-mobile
   Database: DeploymentLogger_MASTER
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.[User]
	DROP CONSTRAINT DF_User_IsApproved
GO
ALTER TABLE dbo.[User]
	DROP CONSTRAINT DF_User_IsLockedOut
GO
ALTER TABLE dbo.[User]
	DROP CONSTRAINT DF_User_CreationDate
GO
CREATE TABLE dbo.Tmp_User
	(
	UserID int NOT NULL IDENTITY (1, 1),
	Login varchar(50) NOT NULL,
	Password varchar(50) NOT NULL,
	Email varchar(255) NOT NULL,
	PasswordQuestion varchar(1024) NOT NULL,
	PasswordAnswer varchar(1024) NULL,
	IsApproved bit NOT NULL,
	IsLockedOut bit NOT NULL,
	CreationDate datetime NOT NULL,
	LastLoginDate datetime NULL,
	LastActivityDate datetime NULL,
	LastPasswordChangedDate datetime NULL,
	LastLockoutDate datetime NULL,
	GUID uniqueidentifier NOT NULL,
	IsInactive bit NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_User ADD CONSTRAINT
	DF_User_IsApproved DEFAULT (1) FOR IsApproved
GO
ALTER TABLE dbo.Tmp_User ADD CONSTRAINT
	DF_User_IsLockedOut DEFAULT (0) FOR IsLockedOut
GO
ALTER TABLE dbo.Tmp_User ADD CONSTRAINT
	DF_User_CreationDate DEFAULT (getdate()) FOR CreationDate
GO
SET IDENTITY_INSERT dbo.Tmp_User ON
GO
IF EXISTS(SELECT * FROM dbo.[User])
	 EXEC('INSERT INTO dbo.Tmp_User (UserID, Login, Password, Email, PasswordQuestion, IsApproved, IsLockedOut, CreationDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, LastLockoutDate, GUID, IsInactive)
		SELECT UserID, Login, Password, Email, PasswordQuestion, IsApproved, IsLockedOut, CreationDate, LastLoginDate, LastActivityDate, LastPasswordChangedDate, LastLockoutDate, GUID, IsInactive FROM dbo.[User] WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_User OFF
GO
ALTER TABLE dbo.OrganizationUser
	DROP CONSTRAINT FK_OrganizationUser_User
GO
ALTER TABLE dbo.UserRole
	DROP CONSTRAINT FK_UserRole_User
GO
DROP TABLE dbo.[User]
GO
EXECUTE sp_rename N'dbo.Tmp_User', N'User', 'OBJECT' 
GO
ALTER TABLE dbo.[User] ADD CONSTRAINT
	PK_User PRIMARY KEY CLUSTERED 
	(
	UserID
	) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.UserRole WITH NOCHECK ADD CONSTRAINT
	FK_UserRole_User FOREIGN KEY
	(
	UserID
	) REFERENCES dbo.[User]
	(
	UserID
	)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.OrganizationUser WITH NOCHECK ADD CONSTRAINT
	FK_OrganizationUser_User FOREIGN KEY
	(
	UserID
	) REFERENCES dbo.[User]
	(
	UserID
	)
GO
COMMIT
