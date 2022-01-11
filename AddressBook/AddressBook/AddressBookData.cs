using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookData
    {
        public static void Create_Database()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =master; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create database AddressbookService;", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("AddressbookService Database created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating database:" + e.Message + "\t");
            }
        }
    }
}
