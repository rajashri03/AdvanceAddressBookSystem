using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookData
    {
        /// <summary>
        /// Create Database-Addressbook Service
        /// </summary>
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
        /// <summary>
        /// Created Table in addressbook service database
        /// </summary>
        public static void CreateTables()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =AddressbookService; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create table AddressBook(id int identity(1,1)primary key,First_Name varchar(200),Last_Name varchar(200),Address varchar(200), City varchar(200), State varchar(200), Zip varchar(200), Phone_Number varchar(50), Email varchar(200)); ", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Payroll table has been  created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
        //Created Connection file
        public static string ConnFile = @"Data Source=AD-PC\SQLEXPRESS; Initial Catalog =AddressbookService; Integrated Security = True;";
        SqlConnection connection = new SqlConnection(ConnFile);
        /// <summary>
        /// Method to insert data in database
        /// </summary>
        /// <param name="model"></param>
        public bool AddContact(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("SpAddressBook", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@First_Name", model.First_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", model.Last_Name);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@City", model.City);
                    cmd.Parameters.AddWithValue("@State", model.State);
                    cmd.Parameters.AddWithValue("@Zip", model.Zip);
                    cmd.Parameters.AddWithValue("@Phone_Number", model.Phone_Number);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@AddressbookName", model.AddressbookName);
                    cmd.Parameters.AddWithValue("@Type", model.Type);
                    this.connection.Open();

                    var result = cmd.ExecuteNonQuery();
                    this.connection.Close();
               
                if (result != 0)
                {

                    return true;
                }
                return false;
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
            return false;
        }

        /// <summary>
        /// Fetching all data from Database
        /// </summary>
        public void GetAllContact()
        {
            try
            {
                AddressBookModel addressmodel = new AddressBookModel();
                using (this.connection)
                {
                    string Query = @"Select * from AddressBook";
                    SqlCommand cmd = new SqlCommand(Query, this.connection);
                    this.connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            addressmodel.AddressBookId = datareader.GetInt32(0);
                            addressmodel.First_Name = datareader.GetString(1);
                            addressmodel.Last_Name = datareader.GetString(2);
                            addressmodel.Address = datareader.GetString(3);
                            addressmodel.City = datareader.GetString(4);
                            addressmodel.State = datareader.GetString(5);
                            addressmodel.Zip = datareader.GetString(6);
                            addressmodel.Phone_Number = datareader.GetString(7);
                            addressmodel.Email = datareader.GetString(8);
                            Console.WriteLine(addressmodel.First_Name + " " +
                                addressmodel.Last_Name + " " +
                                addressmodel.Address + " " +
                                addressmodel.City + " " +
                                addressmodel.State + " " +
                                addressmodel.Zip + " " +
                                addressmodel.Phone_Number + " " +
                                addressmodel.Email + " "
                                );
                            Console.WriteLine("------------------------------------------------------------");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
