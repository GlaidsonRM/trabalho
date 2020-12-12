﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho_igor_gladson.Models
{
    public class CarContext: DbContext
    {
        public CarContext(DbContextOptions<CarContext> options):base(options)
        { 
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
