using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace UI.Data
{
    class DataContext: DbContext
    {
        public DataContext()
            : base("DbConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Migrations.Configuration>());
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<ExternalEffect> ExternalEffects { get; set; }
        public DbSet<ElectricDevice> ElectricDevices { get; set; }

    }
}
