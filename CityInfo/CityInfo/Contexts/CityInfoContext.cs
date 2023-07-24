using CityInfo.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace CityInfo.Contexts
{
  public class CityInfoContext : DbContext
  {
    public DbSet<City> Cities { get; set; }
    public DbSet<PointOfInterest> PointsOfInterest { get; set; }

    public DbSet<User> Users { get; set; }
    public CityInfoContext(DbContextOptions<CityInfoContext> options)
       : base(options)
    {
      //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<City>()
           .HasData(
          new City()
          {
            Id = 1,
            Name = "New York City",
            Description = "The one with that big park.",
            Population= 7888121,
            Area= 1223,
            MapsURL= "https://goo.gl/maps/yTTiy8L1FjhYhK3i8"
          },
          new City()
          {
            Id = 2,
            Name = "Antwerp",
           Description = "The one with the cathedral that was never really finished.",
           Population= 536079,
           Area= 204,
           MapsURL= "https://goo.gl/maps/RubRthrVoynjvyTi9"
          },
          new City()
          {
            Id = 3,
            Name = "Paris",
            Description = "The one with that big tower.",
            Population= 2102650,
            Area= 105,
            MapsURL="https://goo.gl/maps/tZ2zjTmQDwNb1x5R9"
          });


      modelBuilder.Entity<PointOfInterest>()
        .HasData(
          new PointOfInterest()
          {
            Id = 1,
            CityId = 1,
            Name = "Central Park",
            Description = "The most visited urban park in the United States.",
            MapsURL= "https://goo.gl/maps/ZfXi1UjzE1DovGFS9"
          },
          new PointOfInterest()
          {
            Id = 2,
            CityId = 1,
            Name = "Empire State Building",
           Description = "A 102-story skyscraper located in Midtown Manhattan.",
           MapsURL= "https://goo.gl/maps/RhLeHfoo3U4KMEsy6"
          },
            new PointOfInterest()
            {
              Id = 3,
              CityId = 2,
              Name = "Cathedral",
              Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans.",
              MapsURL="https://goo.gl/maps/7G37THFH52KMB2WL7"
              
            },
          new PointOfInterest()
          {
            Id = 4,
            CityId = 2,
            Name = "Antwerp Central Station",
           Description = "The the finest example of railway architecture in Belgium.",
           MapsURL= "https://goo.gl/maps/bpcT8jx9yuVjd8Z5A"
          },
          new PointOfInterest()
          {
            Id = 5,
            CityId = 3,
            Name = "Eiffel Tower",
            Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel.",
            MapsURL= "https://goo.gl/maps/a3yoLH55VhV4uk7LA"
          },
          new PointOfInterest()
          {
            Id = 6,
            CityId = 3,
            Name = "The Louvre",
            Description = "The world's largest museum.",
            MapsURL= "https://goo.gl/maps/VbPUHpf3RJbA1Znj7"
          }
          );

      base.OnModelCreating(modelBuilder);
    }
  }
}
