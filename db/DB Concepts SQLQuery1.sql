USE College 
GO
--DROP TABLE Members
--DROP TABLE Tickets
--DROP TABLE Prizes


CREATE TABLE Members(
Mem_ID				NUMERIC(1),
Surname				CHAR(30),
Forename			CHAR(30),
Phone_No			NUMERIC(30),
CONSTRAINT pk_Members PRIMARY KEY(Mem_ID));

CREATE TABLE Tickets(
Ticket_No			NUMERIC(6),
Mem_ID				NUMERIC(1),
Purch_Date			DATE,
CONSTRAINT pk_Tickets PRIMARY KEY(Ticket_No),
CONSTRAINT fk_Tickets FOREIGN KEY(Mem_ID) REFERENCES Members);

CREATE TABLE Prizes(
Prize_ID			NUMERIC(1),
Draw_Date			DATE,
Ticket_NO			NUMERIC(6),
Prize_Ammount		CHAR(12),
CONSTRAINT pk_Prizes PRIMARY KEY(Prize_ID),
CONSTRAINT fk_Prizes FOREIGN KEY(Ticket_No) REFERENCES Tickets);

BEGIN TRANSACTION

INSERT INTO Members VALUES('SMITH','MIKE',0871233400);
INSERT INTO Members VALUES('JONES','TOM',0851236788);
INSERT INTO Members VALUES('KELLY','MARY',0873347764);
INSERT INTO Members VALUES('SMITH','ALAN',0865067126);
INSERT INTO Members VALUES('KENNY','PETER',0875672747);

COMMIT TRANSACTION

BEGIN TRANSACTION

INSERT INTO Tickets VALUES(100001,4,'01-08-2012');
INSERT INTO Tickets VALUES(100002,1,'02-08-2012');
INSERT INTO Tickets VALUES(100003,4,'12-08-2012');
INSERT INTO Tickets VALUES(100004,2,'16-08-2012');

COMMIT TRANSACTION 

BEGIN TRANSACTION

INSERT INTO Prizes VALUES('01-01-2009',100004,'�1,000.00');
INSERT INTO Prizes VALUES('01-01-2009',100001,'�500.00');
INSERT INTO Prizes VALUES('01-02-2009',100003,'�100.000.00');
INSERT INTO Prizes VALUES('01-02-2009',100001,'�25,000.00');

COMMIT TRANSACTION 

SELECT *
FROM Members;

SELECT *
FROM Prizes;

SELECT *
FROM Tickets;

