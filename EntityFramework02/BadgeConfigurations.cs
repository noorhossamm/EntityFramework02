using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework02
{
    internal class BadgeConfigurations : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BadgeNumber)
                   .IsRequired();

            builder.Property(b => b.IssuedDate)
                   .IsRequired();

            builder.Property(b => b.Tier)
                   .IsRequired()
                   .HasMaxLength(10);

            builder.ToTable(t =>
                t.HasCheckConstraint(
                    "CK_Badge_Tier",
                    "[Tier] IN ('Standard', 'VIP')"
                ));

            builder.HasOne(b => b.Attendee)
                   .WithOne(a => a.Badge)
                   .HasForeignKey<Badge>(b => b.AttendeeId)
                   .IsRequired();

            builder.HasIndex(b => b.AttendeeId)
                   .IsUnique();
        }
    }
}
