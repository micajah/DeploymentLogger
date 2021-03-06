/*
   Tuesday, January 17, 20062:52:33 AM
   User: 
   Server: andrews-mobile
   Database: DeploymentLogger
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
ALTER TABLE dbo.[User] ADD
	PasswordQuestion varchar(1024) NOT NULL CONSTRAINT DF_User_PasswordQuestion DEFAULT ' ',
	PasswordAnswer varchar(1024) NULL,
	IsApproved bit NOT NULL CONSTRAINT DF_User_IsApproved_1 DEFAULT (1),
	IsLockedOut bit NOT NULL CONSTRAINT DF_User_IsLockedOut_1 DEFAULT (0),
	CreationDate datetime NOT NULL CONSTRAINT DF_User_CreationDate_1 DEFAULT (getdate()),
	LastActivityDate datetime NULL,
	LastPasswordChangedDate datetime NULL,
	LastLockoutDate datetime NULL
GO
COMMIT
