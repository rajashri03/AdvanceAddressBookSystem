// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("*************AddressBook System******************");
bool status = true;
while(status)
{
    Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create Table\n3)Insert Contact\n" +
    "4)Update Details\n5)Delete COntacts\n6)Fetch Contacts");
    int op = Convert.ToInt16(Console.ReadLine());
    AddressBookData ad = new AddressBookData();
    AddressBookModel addressbook = new AddressBookModel();

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
            addressbook.First_Name = "Sejal";
            addressbook.Last_Name = "Lambe";
            addressbook.Address = "Kale";
            addressbook.City = "Kolhapur";
            addressbook.State = "Maharashtra";
            addressbook.Zip = "982378";
            addressbook.Phone_Number = "9834783456";
            addressbook.Email = "yugansh@gmail.com";
            addressbook.AddressbookName = "2";//Addressbook2
            addressbook.Type = "2";//Friends
            ad.AddContact(addressbook);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Record Inserted successfully");
            Console.ResetColor();
            break;
        case 4:
            Console.WriteLine("************Welcome to Address Book******************");
            addressbook.First_Name = "Rajashri";
            addressbook.Last_Name = "Telvekar";
            addressbook.Address = "Kagal";
            addressbook.City = "Kolhapur";
            addressbook.State = "Mahgarashtra";
            addressbook.Zip = "982378";
            addressbook.Phone_Number = "9876789876";
            addressbook.Email = "rj@gmail.com";
            addressbook.AddressbookName = "1";//Addressbook2
            addressbook.Type = "1";//Family
            ad.UpdateContact(addressbook);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Record Updated successfully");
            Console.ResetColor();
            break;
        case 5:
            Console.WriteLine("************Welcome to Address Book******************");
            addressbook.First_Name = "Sejal";
            ad.DeleteContact(addressbook);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Record Deleted successfully");
            Console.ResetColor();
            break;
        case 6:
            ad.GetAllContact();
            break;
        default:
            status = !status;
            break;
    }
}

