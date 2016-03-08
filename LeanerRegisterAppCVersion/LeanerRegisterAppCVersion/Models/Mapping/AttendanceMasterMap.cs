using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace LeanerRegisterAppCVersion.Models.Mapping
{
    public class AttendanceMasterMap : EntityTypeConfiguration<AttendanceMaster>
    {
        public AttendanceMasterMap()
        {
            // Primary Key
            this.HasKey(t => t.AttndncMstrID);

            // Properties
            this.Property(t => t.TrainingOn)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("AttendanceMaster");
            this.Property(t => t.AttndncMstrID).HasColumnName("AttndncMstrID");
            this.Property(t => t.MentorID).HasColumnName("MentorID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.TrainingOn).HasColumnName("TrainingOn");

            // Relationships
            this.HasRequired(t => t.Person)
                .WithMany(t => t.AttendanceMasters)
                .HasForeignKey(d => d.MentorID);

        }
    }
}
