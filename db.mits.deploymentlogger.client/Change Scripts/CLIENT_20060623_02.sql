/*
   Friday, June 23, 200610:59:14 PM
   User: 
   Server: ANDREWS-MOBILE
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
ALTER TABLE dbo.ProjectNotification
	DROP CONSTRAINT FK_ProjectNotification_Update
GO
COMMIT
BEGIN TRANSACTION
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ProjectNotification WITH NOCHECK ADD CONSTRAINT
	FK_ProjectNotification_Update FOREIGN KEY
	(
	ImpactLevelID
	) REFERENCES dbo.ImpactLevel
	(
	ImpactLevelID
	)
GO
ALTER TABLE dbo.ProjectNotification ADD CONSTRAINT
	FK_ProjectNotification_ProjectNotification FOREIGN KEY
	(
	ProjectNotificationID
	) REFERENCES dbo.ProjectNotification
	(
	ProjectNotificationID
	)
GO
COMMIT
