using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Reqired field")]
        [MaxLength(30,ErrorMessage ="Maximum 60 characters")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Reqired field")]
        [MaxLength(60, ErrorMessage = "Maximum 60 characters")]
        public string Address { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public ICollection<Employee> Employees { get; set; }
    }
}
