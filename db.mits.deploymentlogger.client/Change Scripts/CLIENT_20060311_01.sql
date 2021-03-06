/*਍ഀ
   Saturday, March 11, 20064:45:32 PM਍ഀ
   User: ਍ഀ
   Server: ANDREWS-MOBILE਍ഀ
   Database: DeploymentLogger_MASTER਍ഀ
   Application: ਍ഀ
*/਍ഀ
਍ഀ
/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/਍ഀ
BEGIN TRANSACTION਍ഀ
SET QUOTED_IDENTIFIER ON਍ഀ
SET ARITHABORT ON਍ഀ
SET NUMERIC_ROUNDABORT OFF਍ഀ
SET CONCAT_NULL_YIELDS_NULL ON਍ഀ
SET ANSI_NULLS ON਍ഀ
SET ANSI_PADDING ON਍ഀ
SET ANSI_WARNINGS ON਍ഀ
COMMIT਍ഀ
BEGIN TRANSACTION਍ഀ
GO਍ഀ
ALTER TABLE dbo.[Database] ADD਍ഀ
	ServerID int NULL਍ഀ
GO਍ഀ
ALTER TABLE dbo.[Database] ADD CONSTRAINT਍ഀ
	FK_Database_Database FOREIGN KEY਍ഀ
	(਍ഀ
	DatabaseID਍ഀ
	) REFERENCES dbo.[Database]਍ഀ
	(਍ഀ
	DatabaseID਍ഀ
	)਍ഀ
GO਍ഀ
COMMIT਍ഀ
