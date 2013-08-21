USE UserLogin
GO

DECLARE @CreatedBy				dbo.Verification
DECLARE @CreationTimestamp		datetime

SET @CreatedBy					= 'Administrator'
SET @CreationTimestamp			= GETUTCDATE()

BEGIN TRANSACTION

INSERT INTO	dbo.UserVerification VALUES('User2','password2',@CreatedBy,@CreationTimestamp)

COMMIT TRANSACTION

Select *
FROM UserVerification