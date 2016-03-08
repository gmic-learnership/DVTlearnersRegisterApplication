using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LeanerRegisterAppCVersion.Models.Mapping;

namespace LeanerRegisterAppCVersion.Models
{
    public partial class TheDailyRegisterDBContext : DbContext
    {
        static TheDailyRegisterDBContext()
        {
            Database.SetInitializer<TheDailyRegisterDBContext>(null);
        }

        public TheDailyRegisterDBContext()
            : base("Name=TheDailyRegisterDBContext")
        {
        }

        public DbSet<AttendanceDetail> AttendanceDetails { get; set; }
        public DbSet<AttendanceMaster> AttendanceMasters { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AttendanceDetailMap());
            modelBuilder.Configurations.Add(new AttendanceMasterMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
