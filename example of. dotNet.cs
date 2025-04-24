using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace AdoDotNetExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Select an option:\n1. Insert \n2. Update\n3. Delete\n4. List\n5. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Insert();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        show();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.ReadKey();
            } while (true);
        }
        public static bool Insert()
        {
            return true;
        }
        public static bool Update()
        {
            return true;
        }
        public static bool Delete()
        {
            return true;
        }
        public static void show()
        {
            const string conString = "Data Source = localhost; Database = BCAV; Integrated Security=SSPI;TrustServerCertificate=true";
            //Server = localhost; Initial Catalog = BCAV; Integrated Security=True; Trust_Server_Certificate
            //Data Source = localhost; Database = BCAV; User Id = sa; Password = 123354;

            SqlConnection conn = new SqlConnection(conString);
            //conn.ConnectionString = conString;
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserList", conn);
            conn.Open();
            //do your database stuff
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(Convert.ToString(reader["userName"]));
            }
            reader.Close();
            conn.Close();
        }
    }
}