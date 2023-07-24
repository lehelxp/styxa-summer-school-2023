using AutoMapper;
using CityInfo.Contexts;
using CityInfo.Entities;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace CityInfo.Controllers
{
  [ApiController]
  [Route("api/cities/{cityId}/pointsOfInterest")]
  public class PointsOfInterestsController : Controller
  {
        private readonly CityInfoContext _ctx;
        private readonly IMapper _mapper;
        public PointsOfInterestsController(CityInfoContext ctx, IMapper mapper)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    [HttpGet]
    public IActionResult GetPointOfInterests(int cityId)
        {
            var cities = _ctx.Cities;
      City city = cities.FirstOrDefault(x => x.Id == cityId);

      if (city == null)
      {
        return BadRequest();
      }
            var pois = _ctx.PointsOfInterest.Where(x=>x.CityId==cityId).ToList();
            List<PointOfInterestDto> poiResponsesList=_mapper.Map<List<PointOfInterestDto>>(pois);
            return Ok(poiResponsesList);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetPointOfInterest(int cityId, int id)
    {
            var cities=_ctx.Cities;
            var pois = _ctx.PointsOfInterest;
      City city = cities.FirstOrDefault(x => x.Id == cityId);

      if (city == null)
      {
        return BadRequest();
      }
      List<PointOfInterest> Citypois = pois.Where(x => x.CityId == cityId).ToList();
            List<PointOfInterestDto> poiResponsesList = _mapper.Map<List<PointOfInterestDto>>(Citypois);   
      return Ok(poiResponsesList.Where(x=>x.Id==id).FirstOrDefault());
    }

    [HttpPost]
    public IActionResult CreatePointOfInterest(int cityId, [FromBody] PointOfInterestDto poi)
    {
            var cities=_ctx.Cities;
      City city = cities.FirstOrDefault(x => x.Id == cityId);

      if (city == null)
      {
        return BadRequest();
      }

      if (poi.Description == poi.Name)
      {
        ModelState.AddModelError(
            "Description",
            "The provided description should be different from the name.");
      }

      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      int maxId = CitiesDataStore.Current.Cities
        .SelectMany(x => x.PointsOfInterest)
        .Max(x => x.Id);

      poi.Id = ++maxId;
            PointOfInterest pointOfInterestEntity = _mapper.Map<PointOfInterest>(poi);
      city.PointsOfInterest.Add(pointOfInterestEntity);

      return Ok(city.PointsOfInterest);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult UpdatePointOfInterest(int cityId, int id, [FromBody] PointOfInterestDto poiFromBody)
    {
            var cities = _ctx.Cities;
      City city = cities.FirstOrDefault(x => x.Id == cityId);

      if (city == null)
      {
        return BadRequest();
      }

      var poi = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);

      poi.Name = poiFromBody.Name;
      poi.Description = poiFromBody.Description;

      return Ok(city.PointsOfInterest);
    }
  }
}
