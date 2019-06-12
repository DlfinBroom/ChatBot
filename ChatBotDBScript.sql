use master
go

drop database ChatbotDB
go

create database ChatbotDB
go

use ChatbotDB
go

Create table Responce(
	ResponceID	int identity primary key,
	Input		varchar(200) not null,
	[Output]	varchar(200) not null
)

insert into Responce(
	 Input, [Output]
) values(
	'Hi', 'Hello'),(
	'Hello', 'Hi'
)