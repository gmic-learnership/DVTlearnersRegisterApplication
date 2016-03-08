using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace LeanerRegisterAppCVersion.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.LastName)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.Contact)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.EmailAdress)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            this.Property(t => t.Password)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Person");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.DateOfBirth).HasColumnName("DateOfBirth");
            this.Property(t => t.Contact).HasColumnName("Contact");
            this.Property(t => t.EmailAdress).HasColumnName("EmailAdress");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.RoleID).HasColumnName("RoleID");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.Person)
                .HasForeignKey(d => d.RoleID);

        }
    }
}
