/*
   Saturday, March 11, 200612:43:55 PM
   User: 
   Server: ANDREWS-MOBILE
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
CREATE TABLE dbo.Server
	(
	ServerID int NOT NULL IDENTITY (1, 1),
	mailHost varchar(255) NULL,
	mailUser varchar(255) NULL,
	mailPass varchar(255) NULL,
	mailEmail varchar(255) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Server ADD CONSTRAINT
	PK_Server PRIMARY KEY CLUSTERED 
	(
	ServerID
	) ON [PRIMARY]

GO
COMMIT
