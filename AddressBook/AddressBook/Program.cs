// See https://aka.ms/new-console-template for more information
using AddressBook;

Console.WriteLine("*************AddressBook System******************");
bool status = true;

List<AddressBookModel> addresslist = new List<AddressBookModel>()
        {
            new AddressBookModel(){First_Name="Rajashri",Last_Name="Telvekar",Address="Kagal",City="Kolhapur",State="MH",Zip="416216",Phone_Number="9887876789",Email="telvekar.rajashri@gmail.com",AddressbookName="AddressBook1",Type="Family"},
            new AddressBookModel(){First_Name="Suraj",Last_Name="Telvekar",Address="Kaneri",City="Pune",State="MH",Zip="416216",Phone_Number="9887876789",Email="telvekar.rajashri@gmail.com",AddressbookName="AddressBook1",Type="Family"}
        };
while (status)
{
    Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create Table\n3)Insert Contact\n" +
    "4)Update Details\n5)Delete COntacts\n6)Fetch Contacts\n7)DataTables-AddressBook");
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
        case 7:
            AddressBook_Linq.Retrive_City_StateRecord(addresslist);
            break;
        default:
            status = !status;
            break;
    }
}

