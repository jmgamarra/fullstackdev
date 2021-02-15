CREATE TABLE [dbo].[Users](
	[email] [varchar](20) NULL,
	[password] [varchar](100) NULL
)


go

create proc [dbo].[usp_Validate_User](@email varchar(20),@password varchar(100))
as
begin
select count(*)as DBResponse from Users where email=@email and password=@password;
end

go
insert into Users values('test@gmail.com','123456');