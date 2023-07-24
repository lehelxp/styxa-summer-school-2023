using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.Entities
{
  public class PointOfInterest
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [MaxLength(200)]
    public string Description { get; set; }
    public City City { get; set; }

    public int CityId { get; set; }
    public string MapsURL { get; set; }
    public string Image { get;set; }
  }
}
