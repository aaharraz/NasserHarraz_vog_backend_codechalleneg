using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VogCodeChallenge.API.Models
{
    public class Department
    {
        public Department()
        {
        }

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
