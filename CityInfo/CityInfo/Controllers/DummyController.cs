using CityInfo.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
[Route("api/testdatabase")]
public class DummyController : ControllerBase
{
  private readonly CityInfoContext _ctx;

  public DummyController(CityInfoContext ctx)
  {
    _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
  }

  [HttpGet]
  public IActionResult TestDatabase()
  {
    return Ok(_ctx.Cities);
  }
}