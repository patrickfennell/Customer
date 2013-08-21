USE Customer
Go

/*
-- Drop Tables

DROP TABLE dbo.Member
GO

-- Drop Types

DROP TYPE dbo.UserName
GO

*/
_--Sql_________________________________________________________________________________________________________
USE Customer												--Do this first creates type username
Go															


CREATE TYPE dbo.UserName FROM varchar(100)
PRINT 'Description user defined data type created'

--Table Creation this creates a table

CREATE TABLE dbo.Member (
Id						int NOT NULL,
Firstname				varchar(100) NOT NULL,
Lastname				varchar(100) NOT NULL,
Email					varchar(100) NOT NULL,
Gender					varchar(50) NOT NULL,
Age						int NOT NULL,
CreatedBy				dbo.UserName NOT NULL, 
CreationTimestamp		datetime NOT NULL,
)  ON [PRIMARY]
ALTER TABLE dbo.Member ADD CONSTRAINT PK_Member PRIMARY KEY CLUSTERED (Id)
PRINT 'Member table created'



