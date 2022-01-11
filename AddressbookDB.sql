/*Uc1-Create address book service database"*/
Create database AddressbookService;

/*Uc2-Create Addressbook Table*/
Create table AddressBook(id int identity(1,1)primary key,First_Name varchar(200),Last_Name varchar(200),
Address varchar(200),City varchar(200),State varchar(200),Zip varchar(200),Phone_Number varchar(50),Email varchar(200));

/*Uc3-Insert New Record*/
Insert into AddressBook(First_Name,Last_Name,Address,City,State,Zip,Phone_Number,Email)
values('Sita','Jaiswal','Ahamadabad','Surat','Gujrat','423325','6555567667','jaiswal.sita@gmail.com');
select * from AddressBook;

/*UC4-Update contact*/
Update AddressBook set Last_Name='Patil', Address='Kaneri',City='Nipani',State='Karnataka',
Zip='456643',Phone_Number='7678767876',Email='rajashri.patil@gmail.com' where First_Name='Rajashri';

/*UC5-delete record using Person name*/
delete from AddressBook where First_Name='Rajashri';

/*Uc6-retrive data using city or state*/
Select * from AddressBook where City='Kolhapur' or State='Maharashtra';

/*UC7-Size of the address book*/
Select Count(id) as AddressBookSize from AddressBook;/*Count is Two*/
Select Count(id) as AddressBookSize from AddressBook where City='Kolhapur' or State='Maharashtra';/*Count is one*/
Select Count(id) as AddressBookSize from AddressBook where City='Sadalaga' or State='Karanataka';/*Count is one*/

/*UC8-display data in Alphabetic order*/
select * from AddressBook AddressBook where City='Sadalaga' or State='Karanataka' order by First_Name asc;

/*UC9-Alter addressbookname and type*/
Alter Table AddressBook Add AddressbookName varchar(200),Type varchar(160);
/*updated vales for addrssbook name and type*/
update AddressBook set AddressbookName='Book1', Type='Friends' where id=3;
update AddressBook set AddressbookName='Book2', Type='Family' where id=4;
update AddressBook set AddressbookName='Book2', Type='Family' where id=5;
update AddressBook set AddressbookName='Book3', Type='Profession' where id=6;
update AddressBook set AddressbookName='Book3', Type='Profession' where id=7;


/*UC10 Count person by Type*/
Select Count(id) as AddressBookSize from AddressBook;/*Count is 6*/
Select Count(id) as AddressBookSize from AddressBook where Type='Friends';/* Count-2*/
Select Count(id) as AddressBookSize from AddressBook where Type='Family';/* Count-2*/
Select Count(id) as AddressBookSize from AddressBook where Type='Profession';/* Count-2*/

/* Created addressbook Name table*/
Create table AddressBookName(AddressBookId int identity(1,1) primary key,AddressBookName varchar(100),Type varchar(100));
Create table AddressTypes(TypeId int identity(1,1) primary key,Type varchar(100));
insert into AddressBookName(AddressBookName,Type)values('AddressBook1','Family');
insert into AddressBookName(AddressBookName,Type)values('AddressBook2','Friends');
insert into AddressBookName(AddressBookName,Type)values('AddressBook3','Profession');

select * from AddressBookName;

select * from AddressBook;

select * from AddressTypes;

Insert into AddressTypes(Type)
values('Friends');
/*UC11-Add person to both friend and family type*/
/*Inserting record for family type Id for friend type is 1*/
Insert into AddressBook(First_Name,Last_Name,Address,City,State,Zip,Phone_Number,Email,AddressbookName,Type)
values('Sita','Jaiswal','Ahamadabad','Surat','Gujrat','423325','6555567667','jaiswal.sita@gmail.com','1','1');
/*Inserting record for Friends type --Id for friend type is 2*/
Insert into AddressBook(First_Name,Last_Name,Address,City,State,Zip,Phone_Number,Email,AddressbookName,Type)
values('Ram','Shintre','Kagal','Kolhapur','Gujrat','423325','6555567667','jaiswal.sita@gmail.com','2','2');

/*UC12--In addressbookService Database there are two tables are present-1 is addressbook and 2 is AddressBookName */
select a.First_Name,a.Last_Name,a.Address,a.City,a.State,a.Zip,a.Phone_Number,a.Email,b.AddressBookName,c.Type from AddressBook a inner join 
AddressBookName b on a.AddressbookName=b.AddressBookId inner join
AddressTypes c on a.Type=c.Typeid;


/*UC13-*/
/*UC6*/
select a.First_Name,a.Last_Name,a.Address,a.City,a.State,a.Zip,a.Phone_Number,a.Email,b.AddressBookName,c.Type from AddressBook a inner join 
AddressBookName b on a.AddressbookName=b.AddressBookId inner join
AddressTypes c on a.Type=c.Typeid where City='Kolhapur' or State='Maharashtra';

