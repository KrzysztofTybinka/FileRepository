﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public virtual IEnumerable<User> Users { get; set; }
    }
}
