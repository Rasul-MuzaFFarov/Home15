
using Domain.Dtos.Locations;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LocationsController :ControllerBase
{
    private readonly LocationService _locationService;

    public LocationsController(LocationService locationService)
    {
        _locationService = locationService;
    }

    
    [HttpGet("GetLocationsById")]
    public Location GetLocationById(int id)
    {
        return  _locationService.GetLocationById(id);
    }
    
    [HttpPost("AddLocationsr")]
    public AddLocation AddLocation(LocationBase location) 
    {
        return _locationService.AddLocation(location) as AddLocation;
    }
    
    [HttpPut("UpdateLocations")]
    public LocationBase UpdateLocation(LocationBase location)
    {
        return _locationService.UpdateLocation(location);
    }
    
    [HttpDelete("DeleteLocations")]
    public bool DeleteLocations(int id)
    {
        return _locationService.DeleteLocation(id);
    }
    
    
}