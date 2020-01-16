using System;
using System.Collections.Generic;

namespace VogCodeChallenge.API.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
    }
}
