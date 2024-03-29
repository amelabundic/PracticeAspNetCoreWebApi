using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Required field")]
        [MaxLength(30,ErrorMessage ="Maximum 30 characters")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Required field")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Required field")]
        [MaxLength(20, ErrorMessage = "Maximum 20 characters")]
        public string Position { get; set; } = string.Empty;
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
