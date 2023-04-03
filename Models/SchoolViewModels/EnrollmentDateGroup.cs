using System.ComponentModel.DataAnnotations;

namespace _205051924lLab8.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    { 
            [DataType(DataType.Date)]
            public DateTime? EnrollmentDate { get; set; }
            public int StudentCount { get; set; } 
    }
} 
