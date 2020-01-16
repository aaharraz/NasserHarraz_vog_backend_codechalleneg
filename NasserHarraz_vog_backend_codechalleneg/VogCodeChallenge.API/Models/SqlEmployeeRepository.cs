using System;
using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge.API.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly VogDbContext vogDbContext;
        public SqlEmployeeRepository(VogDbContext vogDbContext)
        {
            this.vogDbContext = vogDbContext;
        }

        IEnumerable<Employee> IEmployeeRepository.GetAll()
        {
            return vogDbContext.Employees;
        }

        IList<Employee> IEmployeeRepository.ListAll()
        {
            return vogDbContext.Employees.ToList();
        }
    }
}
