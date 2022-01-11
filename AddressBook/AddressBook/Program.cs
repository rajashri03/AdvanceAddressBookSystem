// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("*************AddressBook System******************");
Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create Table");
int op = Convert.ToInt16(Console.ReadLine());
switch(op)
{
    case 1:
        AddressBookData.Create_Database();
        break;
    case 2:
        AddressBookData.CreateTables();
        break;
    default:
        Console.WriteLine("Wrong Choice");
        break;
}
