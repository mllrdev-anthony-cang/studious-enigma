﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ACSC.BL
{
    public class AddressRepository
    {
        DBConnection dbStr = new DBConnection();

        public List<Address> GetBy(Address address)
        {
            using (IDbConnection db = new SqlConnection(dbStr.ToString()))
            {
                var result = db.Query<Address>(SqlView(address)).ToList();
                return result;
            }
        }

        public string SqlView(Address address)
        {
            string sql = $"SELECT TOP 1000 * FROM Address WHERE MarkAs = 'Active' AND CustomerId = {address.CustomerId}";
            var validlist = address.ValidateSearchField;

            if (validlist.Count() < 1)
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
                    sql += $" Id = {address.Id}";
                    break;
                }
                if (string.Equals(validitem, "HouseBuildingStreet")) sql += $" HouseBuildingStreet LIKE '%{address.HouseBuildingStreet}%'";
                if (string.Equals(validitem, "Province")) sql += $" Province LIKE '%{address.Province}%'";
                if (string.Equals(validitem, "CityMunicipality")) sql += $" CityMunicipality LIKE '%{address.CityMunicipality}%'";
                if (string.Equals(validitem, "Barangay")) sql += $" Barangay LIKE '%{address.Barangay}%'";
            }
            return sql;
        }

        public bool Save(Address address)
        {
            bool success = false;
            string sql;

            if (address.Validate == true)
            {
                if (address.Id < 1)
                {
                    sql = "INSERT INTO Address" +
                        "(HouseBuildingStreet, Province, CityMunicipality, Barangay, CustomerId, MarkAs) " +
                        "VALUES" +
                        "(@HouseBuildingStreet, @Province, @CityMunicipality, @Barangay, @CustomerId, @MarkAs)";
                }
                else
                {
                    sql = "UPDATE Address SET " +
                        "HouseBuildingStreet = @HouseBuildingStreet, " +
                        "Province = @Province, " +
                        "CityMunicipality = @CityMunicipality, " +
                        "Barangay = @Barangay " +
                        "WHERE Id = @Id AND CustomerId = @CustomerId";
                }

                using (IDbConnection db = new SqlConnection(dbStr.ToString()))
                {
                    var result = db.Execute(sql, new
                    {
                        Id = address.Id,
                        HouseBuildingStreet = address.HouseBuildingStreet,
                        Province = address.Province,
                        CityMunicipality = address.CityMunicipality,
                        Barangay = address.Barangay,
                        CustomerId = address.CustomerId,
                        MarkAs = "Active"
                    });
                }
                success = true;
            }
            return success;
        }

        public bool Remove(Address address)
        {
            bool success = false;
            string sql = "UPDATE Address SET MarkAs = @MarkAs WHERE Id = @Id";

            if (address.Id < 1) return success;

            using (IDbConnection db = new SqlConnection(dbStr.ToString()))
            {
                var result = db.Execute(sql, new
                {
                    Id = address.Id,
                    MarkAs = "Removed"
                });
            }
            success = true;

            return success;
        }
    }
}
