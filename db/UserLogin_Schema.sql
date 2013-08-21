USE UserLogin
Go

/*
-- Drop Tables

DROP TABLE dbo.UserVerification
GO

-- Drop Types

DROP TYPE dbo.UserName
GO

*/
_--Sql

USE UserLogin												--Do this first creates type username
Go															


CREATE TYPE dbo.UserName FROM varchar(100)
PRINT 'Description user defined data type created'

--Table Creation this creates a table

CREATE TABLE dbo.UserVerification (
Id						int NOT NULL,
Username				varchar(100) NOT NULL,
Password				varchar(100) NOT NULL,
CreatedBy				dbo.UserName NOT NULL, 
CreationTimestamp		datetime NOT NULL,
)  ON [PRIMARY]
ALTER TABLE dbo.UserVerification ADD CONSTRAINT PK_Member PRIMARY KEY CLUSTERED (Id)
PRINT 'UserVerification table created'