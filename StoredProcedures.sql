alter procedure dbo.SpAddressBook
(
	@First_Name varchar(200),
	@Last_Name varchar(200),
	@Address varchar(200),
	@City varchar(200),
	@State varchar(200),
	@Zip varchar(100),
	@Phone_Number varchar(200),
	@Email varchar(200),
	@AddressbookName int,
	@Type int
)
as
begin
insert into AddressBook values(@First_Name,@Last_Name,@Address,@City,@State,@Zip,@Phone_Number,@Email,@AddressbookName,@Type);
SET NOCOUNT ON;
SELECT First_Name,Last_Name,Address,City,State,Zip,Phone_Number,Email,AddressbookName,Type from AddressBook
END
GO