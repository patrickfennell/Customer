--Insert Statement
USE Customer
GO

DECLARE @CreatedBy				dbo.UserName
DECLARE @CreationTimestamp		datetime

SET @CreatedBy					= 'Administrator'
SET @CreationTimestamp			= GETUTCDATE()

BEGIN TRANSACTION

INSERT INTO	dbo.Member VALUES(1,'John','Jones','john@gmail.com','Male','21',@CreatedBy,@CreationTimestamp)

COMMIT TRANSACTION