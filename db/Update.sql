
USE Customer
GO

DECLARE @CreatedBy				dbo.UserName
DECLARE @CreationTimestamp		datetime

SET @CreatedBy					= 'Administrator'
SET @CreationTimestamp			= GETUTCDATE()

BEGIN TRANSACTION

INSERT INTO	dbo.Member values('John','Shea','john@gmail.com','null','32',@CreatedBy,@CreationTimestamp)

COMMIT TRANSACTION

SELECT *
FROM
Member

UPDATE Member set Gender = 'Male'
WHERE Id = 49