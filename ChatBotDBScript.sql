use master;
if EXISTS(select * from sys.databases where name='ChatBotDB')
drop database ChatBotDB;
go

Create Database ChatBotDB;
Go

use ChatBotDB
go

Create Table Responce(
	ResponceID int Primary key,
	[Input] varchar(200) not null,
	[Output] varchar(200) not null
);

Insert into Responce
(ResponceID, [Input], [Output])
Values
(1, 'Hello', 'Hi')