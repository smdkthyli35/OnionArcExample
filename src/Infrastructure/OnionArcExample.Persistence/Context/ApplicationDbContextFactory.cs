﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence.Context
{
    public class ApplicationDbContextFactory : DesignTimeDbContextFactory<ApplicationDbContext>
    {
        protected override ApplicationDbContext CreateNewInstance(DbContextOptions<ApplicationDbContext> options)
        {
            return new ApplicationDbContext(options);
        }
    }
}
