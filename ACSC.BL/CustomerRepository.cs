using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ACSC.BL
{    
    public class CustomerRepository
    {
        DBConnection dbStr = new DBConnection();
        
        public List<Customer> GetBy(Customer customer)
        {        
            using (IDbConnection db = new SqlConnection(dbStr.ToString()))
            {
                var result = db.Query<Customer>(SqlView(customer)).ToList();
                return result;
            }
        }

        public string SqlView(Customer customer)
        {
            string sql = "SELECT TOP 1000 * FROM Customer WHERE MarkAs = 'Active'";
            var validlist = customer.ValidateSearchField;

            if(validlist.Count() < 1)
            {
                return sql;
            }
            else
            {
                sql += " AND";
            }

            foreach (var validitem in validlist)
            {
                if (validlist.IndexOf(validitem) > 0) sql += " AND";
                if (string.Equals(validitem, "Id"))
                {
                    sql += $" Id = {customer.Id}";
                    break;
                }
                if (string.Equals(validitem, "FirstName")) sql += $" FirstName LIKE '{customer.FirstName}%'";
                if (string.Equals(validitem, "LastName")) sql += $" LastName LIKE '{customer.LastName}%'";
                if (string.Equals(validitem, "PhoneNumber")) sql += $" PhoneNumber LIKE '{customer.PhoneNumber}%'";
            }
            return sql;
        }
        
        public bool Save(Customer customer)
        {
            bool success = false;
            string sql;

            if (customer.Validate == true)
            {
                if(customer.Id < 1)
                {
                    sql = "INSERT INTO Customer(FirstName, LastName, PhoneNumber, MarkAs) VALUES(@FirstName, @LastName, @PhoneNumber, @MarkAs)";
                }
                else
                {
                    sql = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber WHERE Id = @Id";
                }
                
                using (IDbConnection db = new SqlConnection(dbStr.ToString()))
                {
                    var result = db.Execute(sql, new {
                        Id = customer.Id,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        PhoneNumber = customer.PhoneNumber,
                        MarkAs = "Active"
                    });
                }
                success = true;
            }
            return success;
        }

        public bool Remove(Customer customer)
        {
            bool success = false;
            string sql = "UPDATE Customer SET MarkAs = @MarkAs WHERE Id = @Id";

            if (customer.Id < 1) return success;

            using (IDbConnection db = new SqlConnection(dbStr.ToString()))
            {
                var result = db.Execute(sql, new
                {
                    Id = customer.Id,
                    MarkAs = "Removed"
                });
            }
            success = true;

            return success;
        }
    }
}
