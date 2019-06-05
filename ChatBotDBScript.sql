use master
go

drop database ChatbotDB
go

create database ChatbotDB
go

use ChatbotDB
go

Create table Responce(
	ResponceID	int	primary key,
	Input		varchar(200) not null,
	[Output]	varchar(200) not null
)

insert into Responce(
	ResponceID, Input, [Output]
) values(
	1, 'Hi', 'Hello'),(
	2, 'Hello', 'Hi'
)