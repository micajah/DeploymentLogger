/*
   Thursday, February 09, 20063:31:25 AM
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
ALTER TABLE dbo.LogEntryStatus ADD
	StatusOrder int NULL,
	ButtonText varchar(255) NULL
GO
COMMIT
