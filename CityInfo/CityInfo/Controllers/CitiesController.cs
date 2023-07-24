using AutoMapper;
using CityInfo.Contexts;
using CityInfo.Entities;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.Controllers
{
  [ApiController]
  [Route("api/cities")]
  public class CitiesController : Controller
  {
    private readonly CityInfoContext _ctx;
    private readonly IMapper _mapper;

    public CitiesController(CityInfoContext ctx, IMapper mapper)
    {
      _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
      _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    [Route("")]
    public IActionResult GetCities()
    {
      //var cities = new CitiesDataStore().Cities;
      //var cities = CitiesDataStore.Current.Cities;

      List<City> cityEntitiesList = _ctx.Cities.ToList();

      List<CityDto> cityResponsesList = _mapper.Map<List<CityDto>>(cityEntitiesList);

      return Ok(cityResponsesList);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetCityById(int id)
    {
      var cities = _ctx.Cities;
      City cityEntity = cities.Where(x => x.Id == id).FirstOrDefault();

      if (cityEntity == null)
      {
        return NotFound();
      }

      CityDto cityResponse = _mapper.Map<CityDto>(cityEntity);

      return Ok(cityResponse);
    }

    [HttpPost]
    [Route("")]
    public IActionResult CreateCity([FromBody]CityDto cityFromParams)
    {
      var cities = _ctx.Cities;

      City cityEntity = _mapper.Map<City>(cityFromParams);

      cities.Add(cityEntity);
      _ctx.SaveChanges();

      return Ok(cities);
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult UpdateCity(int id, [FromBody] CityDto cityFromParams)
    {
      var cities = _ctx.Cities;
      City city = cities.Where(x => x.Id == id).FirstOrDefault();

      if (city == null)
      {
        return NotFound(city);
      }

      city = _mapper.Map<City>(cityFromParams);

      _ctx.SaveChanges();

      return Ok(cities);
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult DeleteCity(int id)
    {
      var cities = _ctx.Cities;
      City city = cities.Where(x => x.Id == id).FirstOrDefault();

      if (city == null)
      {
        return NotFound(city);
      }

      cities.Remove(city);
      _ctx.SaveChanges();

      return Ok(cities);
    }
  }
}
