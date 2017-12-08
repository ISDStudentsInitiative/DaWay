﻿using Dapper;
using InstaBotLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace InstaBotLibrary.Repositories
{
    class FilterRepository : Repository, IFilterRepository
    {
        public FilterRepository() { }
        public FilterRepository(string str) : base(str) { }



        public void AddFilter(FilterModel filter)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = "INSERT INTO Filters (BoundId, Filter) VALUES(@BoundId, @Filter)";
                db.Execute(sqlQuery, filter);
            }
        }

        public void DeleteFilter(FilterModel filter)
        {
            using (IDbConnection db = GetConnection())
            {
                var sqlQuery = "DELETE FROM Users WHERE BoundId = @BoundId AND Filter = @Filter";
                db.Execute(sqlQuery, filter);
            }
        }

        public List<FilterModel> getBoundFilters(int boundId)
        {
            List<FilterModel> filters = null;
            using (IDbConnection db = GetConnection())
            {
                filters = db.Query<FilterModel>("SELECT * FROM Filters WHERE BoundId = @boundId", new { boundId }).ToList();
            }
            return filters;
        }
    }
}
