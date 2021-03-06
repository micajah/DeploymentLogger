/*
   Thursday, February 09, 20063:38:05 AM
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
CREATE TABLE dbo.Tmp_LogEntryStatus
	(
	LogEntryStatusID int NOT NULL IDENTITY (1, 1),
	Name varchar(1024) COLLATE Cyrillic_General_CI_AS NOT NULL,
	Description varchar(8000) COLLATE Cyrillic_General_CI_AS NULL,
	StatusOrder int NOT NULL,
	ButtonText varchar(255) NULL
	)  ON [PRIMARY]
GO
SET IDENTITY_INSERT dbo.Tmp_LogEntryStatus ON
GO
IF EXISTS(SELECT * FROM dbo.LogEntryStatus)
	 EXEC('INSERT INTO dbo.Tmp_LogEntryStatus (LogEntryStatusID, Name, Description, StatusOrder, ButtonText)
		SELECT LogEntryStatusID, Name, Description, StatusOrder, ButtonText FROM dbo.LogEntryStatus WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_LogEntryStatus OFF
GO
ALTER TABLE dbo.LogEntry
	DROP CONSTRAINT FK_LogEntry_LogEntryStatus
GO
ALTER TABLE dbo.LogEntryStatusNotificationType
	DROP CONSTRAINT FK_LogEntryStatusNotificationType_LogEntryStatus
GO
DROP TABLE dbo.LogEntryStatus
GO
EXECUTE sp_rename N'dbo.Tmp_LogEntryStatus', N'LogEntryStatus', 'OBJECT' 
GO
ALTER TABLE dbo.LogEntryStatus ADD CONSTRAINT
	PK_LogEntryStatus PRIMARY KEY CLUSTERED 
	(
	LogEntryStatusID
	) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LogEntryStatusNotificationType WITH NOCHECK ADD CONSTRAINT
	FK_LogEntryStatusNotificationType_LogEntryStatus FOREIGN KEY
	(
	LogEntryStatusID
	) REFERENCES dbo.LogEntryStatus
	(
	LogEntryStatusID
	)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.LogEntry WITH NOCHECK ADD CONSTRAINT
	FK_LogEntry_LogEntryStatus FOREIGN KEY
	(
	LogEntryStatusID
	) REFERENCES dbo.LogEntryStatus
	(
	LogEntryStatusID
	)
GO
COMMIT
