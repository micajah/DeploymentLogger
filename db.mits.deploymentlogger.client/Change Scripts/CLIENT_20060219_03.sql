/*
   Monday, February 20, 20062:48:49 AM
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
ALTER TABLE dbo.[Update]
	DROP CONSTRAINT FK_Update_User
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.[Update]
	DROP CONSTRAINT FK_Update_UpdateStatus
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.[Update]
	DROP CONSTRAINT FK_Update_Project
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.[Update]
	DROP CONSTRAINT FK_Update_UpdateGroup
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Update
	(
	UpdateID int NOT NULL IDENTITY (1, 1),
	Name varchar(8000) NULL,
	Description text NULL,
	UpdateGroupID int NOT NULL,
	ProjectID int NOT NULL,
	UpdateStatusID int NOT NULL,
	EnteredUserID int NOT NULL,
	EnteredDate datetime NOT NULL,
	BuildNumber varchar(50) NULL,
	BuildDate datetime NOT NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_Update ON
GO
IF EXISTS(SELECT * FROM dbo.[Update])
	 EXEC('INSERT INTO dbo.Tmp_Update (UpdateID, Name, Description, UpdateGroupID, ProjectID, UpdateStatusID, EnteredUserID, EnteredDate, BuildNumber, BuildDate)
		SELECT UpdateID, Name, Description, UpdateGroupID, ProjectID, UpdateStatusID, EnteredUserID, EnteredDate, BuildNumber, BuildDate FROM dbo.[Update] WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Update OFF
GO
ALTER TABLE dbo.ProjectNotification
	DROP CONSTRAINT FK_ProjectNotification_Update
GO
ALTER TABLE dbo.LogEntry
	DROP CONSTRAINT FK_LogEntry_Update
GO
DROP TABLE dbo.[Update]
GO
EXECUTE sp_rename N'dbo.Tmp_Update', N'Update', 'OBJECT' 
GO
ALTER TABLE dbo.[Update] ADD CONSTRAINT
	PK_Update PRIMARY KEY CLUSTERED 
	(
	UpdateID
	) ON [PRIMARY]

GO
ALTER TABLE dbo.[Update] WITH NOCHECK ADD CONSTRAINT
	FK_Update_UpdateGroup FOREIGN KEY
	(
	UpdateGroupID
	) REFERENCES dbo.UpdateGroup
	(
	UpdateGroupID
	)
GO
ALTER TABLE dbo.[Update] WITH NOCHECK ADD CONSTRAINT
	FK_Update_Project FOREIGN KEY
	(
	ProjectID
	) REFERENCES dbo.Project
	(
	ProjectID
	)
GO
ALTER TABLE dbo.[Update] WITH NOCHECK ADD CONSTRAINT
	FK_Update_UpdateStatus FOREIGN KEY
	(
	UpdateStatusID
	) REFERENCES dbo.UpdateStatus
	(
	UpdateStatusID
	)
GO
ALTER TABLE dbo.[Update] WITH NOCHECK ADD CONSTRAINT
	FK_Update_User FOREIGN KEY
	(
	EnteredUserID
	) REFERENCES dbo.[User]
	(
	UserID
	)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LogEntry WITH NOCHECK ADD CONSTRAINT
	FK_LogEntry_Update FOREIGN KEY
	(
	UpdateID
	) REFERENCES dbo.[Update]
	(
	UpdateID
	)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ProjectNotification WITH NOCHECK ADD CONSTRAINT
	FK_ProjectNotification_Update FOREIGN KEY
	(
	UpdateID
	) REFERENCES dbo.[Update]
	(
	UpdateID
	)
GO
COMMIT
