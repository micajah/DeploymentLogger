/*
   Friday, March 24, 20062:12:02 AM
   User: andrey.magazinov
   Server: micajah.sql1
   Database: mits_deploymentlogger_client1_beta
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
CREATE TABLE dbo.ImpactLevel
	(
	ImpactLevelID int NOT NULL IDENTITY (1, 1),
	Name varchar(255) NOT NULL,
	Description varchar(1024) NULL,
	Level int
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.ImpactLevel ADD CONSTRAINT
	PK_ImpactLevel PRIMARY KEY CLUSTERED 
	(
	ImpactLevelID
	) ON [PRIMARY]

GO
COMMIT
