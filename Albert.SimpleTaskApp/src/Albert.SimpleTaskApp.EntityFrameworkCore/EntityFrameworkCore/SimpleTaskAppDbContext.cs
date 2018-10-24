﻿using Abp.EntityFrameworkCore;
using Albert.SimpleTaskApp.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Albert.SimpleTaskApp.EntityFrameworkCore
{
    public class SimpleTaskAppDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }

        public SimpleTaskAppDbContext(DbContextOptions<SimpleTaskAppDbContext> options)
            : base(options)
        {

        }
    }
}
