using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace EntityFramework02
{
    internal class OrganzierProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasKey(p=>p.Id);

            builder.HasOne(p => p.Organizer).WithOne(o => o.Profile).HasForeignKey<OrganizerProfile>(p => p.OrganizerId).IsRequired();

            builder.HasIndex(p => p.OrganizerId).IsUnique();
        }
    }
}
