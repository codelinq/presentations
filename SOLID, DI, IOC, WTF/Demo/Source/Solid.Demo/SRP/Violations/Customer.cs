using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Solid.Demo.SRP.Violations
{
    public class Customer
    {
        public Customer(Guid id)
        {
            FetchCustomerById(id);
        }

        public Guid Id { get; private set; }
        public string Name { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name);
        }

        public bool Save()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException("Customer is not valid.");
            }

            bool saved;

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myData"].ConnectionString))
            {
                var sql = "update Customer set Name = '" + Name + "' where id = '" + Id + "'";
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                        saved = true;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return saved;
        }

        private void FetchCustomerById(Guid id)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myData"].ConnectionString))
            {
                var sql = "select Id, Name from Customer where id = '" + id + "'";
                using (var command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Id = reader.GetGuid(0);
                            Name = reader.GetString(1);
                        }
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
