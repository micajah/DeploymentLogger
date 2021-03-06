﻿
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('LoadProjectNotificationByPrimaryKey') AND sysstat & 0xf = 4)
    DROP PROCEDURE [LoadProjectNotificationByPrimaryKey];
GO

CREATE PROCEDURE [LoadProjectNotificationByPrimaryKey]
(
	@ProjectNotificationID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ProjectNotificationID],
		[RoleID],
		[AddressBookEntryID],
		[UserID],
		[ProjectID],
		[UpdateID],
		[NotificationTypeID]
	FROM [ProjectNotification]
	WHERE
		([ProjectNotificationID] = @ProjectNotificationID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: LoadProjectNotificationByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: LoadProjectNotificationByPrimaryKey Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('LoadAllProjectNotification') AND sysstat & 0xf = 4)
    DROP PROCEDURE [LoadAllProjectNotification];
GO

CREATE PROCEDURE [LoadAllProjectNotification]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ProjectNotificationID],
		[RoleID],
		[AddressBookEntryID],
		[UserID],
		[ProjectID],
		[UpdateID],
		[NotificationTypeID]
	FROM [ProjectNotification]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: LoadAllProjectNotification Succeeded'
ELSE PRINT 'Procedure Creation: LoadAllProjectNotification Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('UpdateProjectNotification') AND sysstat & 0xf = 4)
    DROP PROCEDURE [UpdateProjectNotification];
GO

CREATE PROCEDURE [UpdateProjectNotification]
(
	@ProjectNotificationID int,
	@RoleID int = NULL,
	@AddressBookEntryID int = NULL,
	@UserID int = NULL,
	@ProjectID int,
	@UpdateID int = NULL,
	@NotificationTypeID int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	UPDATE [ProjectNotification]
	SET
		[RoleID] = @RoleID,
		[AddressBookEntryID] = @AddressBookEntryID,
		[UserID] = @UserID,
		[ProjectID] = @ProjectID,
		[UpdateID] = @UpdateID,
		[NotificationTypeID] = @NotificationTypeID
	WHERE
		[ProjectNotificationID] = @ProjectNotificationID


	SET @Err = @@Error


	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: UpdateProjectNotification Succeeded'
ELSE PRINT 'Procedure Creation: UpdateProjectNotification Error on Creation'
GO




IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('InsertProjectNotification') AND sysstat & 0xf = 4)
    DROP PROCEDURE [InsertProjectNotification];
GO

CREATE PROCEDURE [InsertProjectNotification]
(
	@ProjectNotificationID int = NULL output,
	@RoleID int = NULL,
	@AddressBookEntryID int = NULL,
	@UserID int = NULL,
	@ProjectID int,
	@UpdateID int = NULL,
	@NotificationTypeID int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	INSERT
	INTO [ProjectNotification]
	(
		[RoleID],
		[AddressBookEntryID],
		[UserID],
		[ProjectID],
		[UpdateID],
		[NotificationTypeID]
	)
	VALUES
	(
		@RoleID,
		@AddressBookEntryID,
		@UserID,
		@ProjectID,
		@UpdateID,
		@NotificationTypeID
	)

	SET @Err = @@Error

	SELECT @ProjectNotificationID = SCOPE_IDENTITY()

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: InsertProjectNotification Succeeded'
ELSE PRINT 'Procedure Creation: InsertProjectNotification Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('DeleteProjectNotification') AND sysstat & 0xf = 4)
    DROP PROCEDURE [DeleteProjectNotification];
GO

CREATE PROCEDURE [DeleteProjectNotification]
(
	@ProjectNotificationID int
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	DELETE
	FROM [ProjectNotification]
	WHERE
		[ProjectNotificationID] = @ProjectNotificationID
	SET @Err = @@Error

	RETURN @Err
END
GO

-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: DeleteProjectNotification Succeeded'
ELSE PRINT 'Procedure Creation: DeleteProjectNotification Error on Creation'
GO

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE ID = OBJECT_ID('[dbo].[LoadAllUniqueProjectNotificationByProjectID]') AND sysstat & 0xf = 4)
    DROP PROCEDURE [dbo].[LoadAllUniqueProjectNotificationByProjectID]
GO

CREATE PROCEDURE [dbo].[LoadAllUniqueProjectNotificationByProjectID]
(
	@ProjectID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT 	DISTINCT
		nt.NotificationTypeID,
		nt.[Name],
		nt.[Description]
	FROM ProjectNotification pn
	INNER JOIN NotificationType nt
		ON pn.NotificationTypeID = nt.NotificationTypeID
	WHERE	
		pn.ProjectID = @ProjectID

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: LoadAllUniqueProjectNotificationByProjectID Succeeded'
ELSE PRINT 'Procedure Creation: LoadAllUniqueProjectNotificationByProjectID Error on Creation'
GO