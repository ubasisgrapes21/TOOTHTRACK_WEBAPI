using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORIES
{
    public class GenericProcedure<TProcedures>
    {
        public TProcedures? GetAll { get; set; }
        public TProcedures? GetById { get; set; }
        public TProcedures? Insert { get; set; }
        public TProcedures? Update { get; set; }
        public TProcedures? DeleteById { get; set; }
    }

    public class GenericRepository<T, TProcedures>
       where T : class
       where TProcedures : struct, Enum
    {
        public readonly IDbConnection _connection;
        private readonly GenericProcedure<TProcedures> _procedures;
        public readonly int _commandTimeout = 120;
        public GenericRepository(GenericProcedure<TProcedures> procedures)
        {
            _procedures = procedures;
            _connection = new SqlConnection("Server=LAPTOP-0OHJOB60\\MSSQLSERVER01; Database=TOOTHTRACK; Trusted_Connection=True; Encrypt=false");
        }

        // Get All
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _connection.QueryAsync<T>(_procedures.GetAll.ToString(), commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
        }

        // Get By ID
        public async Task<T?> GetById(int id)
        {
            return await _connection.QueryFirstOrDefaultAsync<T>(_procedures.GetById.ToString(), new { Id = id }, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
        }

        // Insert
        public async Task<T?> Insert(T entity)
        {
            return await _connection.QueryFirstOrDefaultAsync<T>(_procedures.Insert.ToString(), entity, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
        }

        // Update
        public async Task<T?> Update(T entity)
        {
            return await _connection.QueryFirstOrDefaultAsync<T>(_procedures.Update.ToString(), entity, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
        }

        // Delete By ID
        public async Task<T?> DeleteById(int id)
        {
            return await _connection.QueryFirstOrDefaultAsync<T>(_procedures.DeleteById.ToString(), new { Id = id }, commandType: CommandType.StoredProcedure, commandTimeout: _commandTimeout);
        }

     
    }
}