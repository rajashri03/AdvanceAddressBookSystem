using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook_Linq
    {
        /// <summary>
        /// Disply all record from list
        /// </summary>
        /// <param name="address"></param>
        public  void Listrecord(List<AddressBookModel> address)
        {
            foreach (var add in address)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"{add.First_Name}\t|{add.Last_Name}\t|{add.Address}\t|{add.City}\t|{add.State}" +
                    $"\t|{add.Zip}\t|{add.Phone_Number}\t|{add.Email}\t|{add.AddressbookName}\t|{add.Type}");
            }
        }
        /// <summary>
        /// Retrive data from list -person belonging to a city or state from list
        /// </summary>
        /// <param name="add"></param>
        public static void Retrive_City_StateRecord(List<AddressBookModel> add)
        {
            
            foreach(var retrivedata in (from adressdata in add
                                      where (adressdata.City == "Kolhapur" || adressdata.State == "MH")
                                      select adressdata))
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("FirstName"+retrivedata.First_Name);
                Console.WriteLine("------------------------------");
            }
        }

    }
}
