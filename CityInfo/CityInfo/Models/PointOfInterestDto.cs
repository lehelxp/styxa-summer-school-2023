using System.ComponentModel.DataAnnotations;

namespace CityInfo.Models
{
  public class PointOfInterestDto
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "The name is mandatory!")]
    [MinLength(3)]
    public string Name { get; set; }
    [Required(ErrorMessage = "The Description field is required, please provide it!")]
    public string Description { get; set; }
    public string MapsUrl { get;set; }
    public string Image { get; set; }

    }
}
