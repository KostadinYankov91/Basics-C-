using System;
using System.Collections.Generic;
using System.Text;

namespace TeisterMask.Common
{
    public class GlobalConstants
    {
        //Employee
        public const int employeeNameMinLength = 3;
        public const int employeeNameMaxLength = 40;
        public const int phoneLength = 12;
        public const string employeeNameRegex = @"^[A-Za-z0-9]+$";
        public const string employeePhoneRegex = @"^\d{3}\-\d{3}\-\d{4}$";


        //Project
        public const int projectNameMaxLength = 40;
        public const int projectNameMinLength = 2;

        //Task
        public const int taskNameMaxLength = 40;
        public const int taskNameMinLength = 2;
        public const int taskExecutionTypeMinLength = 0;
        public const int taskExecutionTypeMaxLength = 3;
        public const int taskLabelTypeMinLength = 0;
        public const int taskLabelTypeMaxLength = 4;


    }
}
