﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sacrament.Models;

namespace Sacrament.Models
{
    public class SacramentContext : DbContext
    {
        public SacramentContext (DbContextOptions<SacramentContext> options)
            : base(options)
        {
        }

        public DbSet<Sacrament.Models.Meeting> Meeting { get; set; }

    }
}
