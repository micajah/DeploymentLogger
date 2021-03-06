/*
   Thursday, March 23, 20064:21:50 PM
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
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LogEntry ADD
	ProjectSectionID int NULL
GO
ALTER TABLE dbo.LogEntry ADD CONSTRAINT
	FK_LogEntry_ProjectSection FOREIGN KEY
	(
	ProjectSectionID
	) REFERENCES dbo.ProjectSection
	(
	ProjectSectionID
	)
GO
COMMIT
