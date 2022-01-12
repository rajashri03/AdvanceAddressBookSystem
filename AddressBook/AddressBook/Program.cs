// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("*************AddressBook System******************");
Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create Table\n3)Insert Contact\n4)Fetch COntacts");
int op = Convert.ToInt16(Console.ReadLine());
AddressBookData ad = new AddressBookData();

switch (op)
{
    case 1:
        AddressBookData.Create_Database();
        break;
    case 2:
        AddressBookData.CreateTables();
        break;
    case 3:
        Console.WriteLine("************Welcome to Address Book******************");
        AddressBookModel addressbook = new AddressBookModel();
        addressbook.First_Name = "Yugansh";
        addressbook.Last_Name = "Shaha";
        addressbook.Address = "Mumbai";
        addressbook.City = "Mumbai";
        addressbook.State = "Maharashtra";
        addressbook.Zip = "982378";
        addressbook.Phone_Number = "9834783456";
        addressbook.Email = "yugansh@gmail.com";
        addressbook.AddressbookName = "1";//Addressbook1
        addressbook.Type = "1";//Family
        ad.AddContact(addressbook);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Record Inserted successfully");
        Console.ResetColor();
        break;
    case 4:
        ad.GetAllContact();
        break;
    default:
        Console.WriteLine("Wrong Choice");
        break;
}
