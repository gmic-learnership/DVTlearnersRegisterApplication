using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace LeanerRegisterAppCVersion.Models.Mapping
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleID);

            // Properties
            this.Property(t => t.RoleType)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Role");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.RoleType).HasColumnName("RoleType");
        }
    }
}
