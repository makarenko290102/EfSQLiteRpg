﻿using Microsoft.EntityFrameworkCore;

namespace EfSQLiteTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<RpgCharacter> RpgCharacters => Set<RpgCharacter>();
    }
}
