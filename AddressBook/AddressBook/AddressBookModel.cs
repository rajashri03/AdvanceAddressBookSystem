using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookModel
    {
        public int AddressBookId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public string AddressbookName { get; set; }
        public string Type { get; set; }
    }
}
