using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.Entities
{
  public class City
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string Description { get; set; }
    public int Population { get; set; }
    public int Area { get; set; }
    public ICollection<PointOfInterest> PointsOfInterest { get; set; }
          = new List<PointOfInterest>();
    public string MapsURL { get; set; }
  }
}
