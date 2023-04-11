using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FeedforwardDAL : MAINDAL
    {
        private static string ConnectionString = "Data Source=tcp:max.brosky.net\\GIGASOFTDB, 1433;Initial Catalog = FeedBUF_DB; Persist Security Info=True;User ID = sa; Password=Gigasoft123";
        public static void AddNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }

        public static void UpdateNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void DeleteNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
        public static void GetNote()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
