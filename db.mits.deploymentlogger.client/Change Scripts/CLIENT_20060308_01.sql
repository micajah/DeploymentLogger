/*
   Thursday, March 09, 20061:30:32 AM
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
EXECUTE sp_rename N'dbo.NotificationType.ProcessingAssembly', N'Tmp_ProcessingAssemblyName', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.NotificationType.Tmp_ProcessingAssemblyName', N'ProcessingAssemblyName', 'COLUMN' 
GO
ALTER TABLE dbo.NotificationType ADD
	ProcessingClassName varchar(1024) NULL,
	ProcessingProcedureName varchar(255) NULL
GO
COMMIT
