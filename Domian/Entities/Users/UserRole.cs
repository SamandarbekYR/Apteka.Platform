using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Entities.Users
{
    public class UserRole : Auditable
    {
        [Column("role_name")]
        public string RoleName { get; set; } = string.Empty;
        public List<User> User { get; set; } = new();
    }
}
