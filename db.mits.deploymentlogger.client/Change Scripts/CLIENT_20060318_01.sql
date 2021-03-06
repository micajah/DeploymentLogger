/*
   Saturday, March 18, 20069:41:28 AM
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
CREATE TABLE dbo.Tmp_Object
	(
	ObjectID int NOT NULL,
	Name varchar(50) NOT NULL,
	Description varchar(255) NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.Object)
	 EXEC('INSERT INTO dbo.Tmp_Object (ObjectID, Name, Description)
		SELECT ObjectID, CONVERT(varchar(50), Name), CONVERT(varchar(255), Description) FROM dbo.Object WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.ActivityLog
	DROP CONSTRAINT FK_ActivityLog_Object
GO
DROP TABLE dbo.Object
GO
EXECUTE sp_rename N'dbo.Tmp_Object', N'Object', 'OBJECT' 
GO
ALTER TABLE dbo.Object ADD CONSTRAINT
	PK_Object PRIMARY KEY CLUSTERED 
	(
	ObjectID
	) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.ActivityLog WITH NOCHECK ADD CONSTRAINT
	FK_ActivityLog_Object FOREIGN KEY
	(
	ObjectID
	) REFERENCES dbo.Object
	(
	ObjectID
	)
GO
COMMIT
