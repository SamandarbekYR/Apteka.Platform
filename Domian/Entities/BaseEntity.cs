using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domian.Entities;

public class BaseEntity
{
    [Column("id")]
    public Guid Id { get; set; }
}
