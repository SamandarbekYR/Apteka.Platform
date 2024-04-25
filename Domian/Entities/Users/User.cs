using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domian.Entities.Users;

[Table("user")]
public class User : Auditable
{
    public string FullName { get; set; } = string.Empty;
    public string PhoneNumber {  get; set; } = string.Empty;
    public string PasswordHash {  get; set; } = string.Empty;
    public string PasswordSalt {  get; set; } = string.Empty;
    public Guid RoleId { get; set; }
    [JsonIgnore]
    public UserRole Role { get; set; } 
}
