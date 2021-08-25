using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidators;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    
        {
            public int EmployeeId { get; set; }
            [MinLength(2)]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [EmailAddress]
            [EmailDomainValidator(AllowedDomain = "pragimtech.com")]
            public string Email { get; set; }
            [CompareProperty("Email", ErrorMessage = "Email must be the same!")]
            public string ConfirmEmail { get; set; }
            public DateTime DateOfBrith { get; set; }
            public Gender Gender { get; set; }
            public int DepartmentId { get; set; }
            public string PhotoPath { get; set; }
        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
