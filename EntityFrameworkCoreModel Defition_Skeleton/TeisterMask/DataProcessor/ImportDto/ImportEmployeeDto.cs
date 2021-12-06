using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    
    public class ImportEmployeeDto
    {
        [Required]
        [MinLength(GlobalConstants.employeeNameMinLength)]
        [MaxLength(GlobalConstants.employeeNameMaxLength)]
        [RegularExpression(GlobalConstants.employeeNameRegex)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(GlobalConstants.employeePhoneRegex)]
        public string Phone { get; set; }
        public int[] Tasks { get; set; }

    }
}
