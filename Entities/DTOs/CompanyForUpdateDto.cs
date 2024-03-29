using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CompanyForUpdateDto
    {
        public string Name { get; set; } =string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
