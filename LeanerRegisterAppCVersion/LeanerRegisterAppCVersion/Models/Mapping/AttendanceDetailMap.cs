using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace LeanerRegisterAppCVersion.Models.Mapping
{
    public class AttendanceDetailMap : EntityTypeConfiguration<AttendanceDetail>
    {
        public AttendanceDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.AttndncDtlsID);

            // Properties
            // Table & Column Mappings
            this.ToTable("AttendanceDetail");
            this.Property(t => t.AttndncDtlsID).HasColumnName("AttndncDtlsID");
            this.Property(t => t.AttndncMstrID).HasColumnName("AttndncMstrID");
            this.Property(t => t.MenteeID).HasColumnName("MenteeID");
            this.Property(t => t.hours).HasColumnName("hours");

            // Relationships
            this.HasRequired(t => t.AttendanceMaster)
                .WithMany(t => t.AttendanceDetails)
                .HasForeignKey(d => d.AttndncMstrID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.AttendanceDetails)
                .HasForeignKey(d => d.MenteeID);

        }
    }
}
