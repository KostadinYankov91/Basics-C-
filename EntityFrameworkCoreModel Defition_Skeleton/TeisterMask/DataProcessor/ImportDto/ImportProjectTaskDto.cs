using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
using TeisterMask.Common;

namespace TeisterMask.DataProcessor.ImportDto
{
    [XmlType("Task")]
    public class ImportProjectTaskDto
    {
        [XmlElement("Name")]
        [Required]
        [MaxLength(GlobalConstants.taskNameMaxLength)]
        [MinLength(GlobalConstants.taskNameMinLength)]
        public string Name { get; set; }

        [XmlElement("OpenDate")]
        [Required]
        public string TaskOpenDate { get; set; }

        [XmlElement("DueDate")]
        [Required]
        public string TaskDueDate { get; set; }

        [XmlElement("ExecutionType")]
        [Range(GlobalConstants.taskExecutionTypeMinLength, GlobalConstants.taskExecutionTypeMaxLength)]
        public int ExecutionType { get; set; }

        [XmlElement("LabelType")]
        [Range(GlobalConstants.taskLabelTypeMinLength, GlobalConstants.taskLabelTypeMaxLength)]
        public int LabelType { get; set; }

    }
}
