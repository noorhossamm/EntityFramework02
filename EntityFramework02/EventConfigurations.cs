using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework02
{
    internal class EventConfigurations : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Description).HasMaxLength(500);

            builder.Property(e => e.StartDate).IsRequired();

            builder.Property(e => e.EndDate)
                   .IsRequired(false);
            builder.HasOne(e => e.Organizer)
       .WithMany(o => o.Events)
       .HasForeignKey(e => e.OrganizerId)
       .IsRequired();
        }
    }
}
