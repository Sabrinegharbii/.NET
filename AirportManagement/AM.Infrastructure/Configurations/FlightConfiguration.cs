using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //Relation ManyToMany
            builder.HasMany(p => p.Passengers)
                .WithMany(f => f.Flights).UsingEntity(
                j => j.ToTable("Reservation"));

            //Relation OneToMany
            builder.HasOne(p => p.plane)
                .WithMany(f => f.Flights)
                .HasForeignKey(p => p.PlaneId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
