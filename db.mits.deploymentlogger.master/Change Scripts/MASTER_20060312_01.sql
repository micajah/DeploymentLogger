/*
   Saturday, March 11, 20069:00:47 PM
   User: andrey.magazinov
   Server: micajah.sql1
   Database: mits_deploymentlogger_master_beta
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
EXECUTE sp_rename N'dbo.[Database].ConnectionString', N'Tmp_DBConnectionString', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.[Database].Tmp_DBConnectionString', N'DBConnectionString', 'COLUMN' 
GO
COMMIT
