using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeesController : ControllerBase
        {
            private readonly IEmployeeRepository _employeeRepository;
            public EmployeesController(IEmployeeRepository employeeRepository)
            {
                this._employeeRepository = employeeRepository;
            }
            // GET: api/Employees
            [HttpGet]
            public IEnumerable<Employee> Get()
            {
                return _employeeRepository.GetAll();
            }

     
            // GET	api/employees/department/{departmentId}
            [HttpGet("department/{departmentId}", Name = "Get")]
            public IEnumerable<Employee> Get(int departmentId)
            {
                return _employeeRepository.GetAll().Where(x => x.DepartmentId == departmentId);
            }

         
        }
}
