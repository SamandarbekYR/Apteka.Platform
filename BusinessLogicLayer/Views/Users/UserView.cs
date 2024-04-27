using Domian.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Views.Users
{
    public class UserView
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;

        public static implicit operator UserView(User user)
        => new() { Id = user.Id,
                   FullName = user.FullName,
                   PhoneNumber = user.PhoneNumber,
                   RoleId = user.RoleId,
                   RoleName = user.Role.RoleName };
    }
}
