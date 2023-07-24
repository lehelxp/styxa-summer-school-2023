using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.Models
{
  public class CityDto
  {
    //[Range(1, 500)]
    public int Id { get; set; }
    [Required(ErrorMessage = "City name is required")]
    //[RegularExpression("*test*")]
    public string Name { get; set; }
    [MinLength(3, ErrorMessage = "Description length is mininum 3 characters")]
    [MaxLength(200, ErrorMessage = "Description length is maximum 200 characters")]
    public string Description { get; set; }
    public List<PointOfInterestDto> PointsOfInterest { get; set; }
  = new List<PointOfInterestDto>();
        public int Population { get; set; }
    public int Area { get; set; }
    public string MapsURL { get; set; } 
    public int PoiNumber { get => PointsOfInterest.Count; }

    public CityDto() { }
    public CityDto(int id, string name, string description)
    {
      Id = id;
      Name = name;
      Description = description;
    }
  }
}
