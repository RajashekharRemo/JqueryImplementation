using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Entity
{
    public class EmployeePayRoll
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }
        public string? ProfileImage { get; set; }
        [Required(ErrorMessage = "Gender is Required")]
        public string? Gender { get; set; }
        [Required(ErrorMessage = "Department is Required")]
        public string? Department { get; set; }
        public double? Salary { get; set; }
        [Required(ErrorMessage = "Notes is Required")]
        public string? Notes { get; set; }
        [Required(ErrorMessage = "StartDate is Required")]
        public DateTime StartDate { get; set; }
    }
}
