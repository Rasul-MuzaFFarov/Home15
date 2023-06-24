
using Domain.Dtos.Locations;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class LocationService
{
    private readonly DataContext _context;

    public LocationService(DataContext context)
    {
        _context = context;
    }

    public LocationBase AddLocation(LocationBase location)
    {
        _context.Locations.Add(new Location()
        {
            Id = location.Id,
            State = location.State,
            City = location.City,
            ZipCode=location.ZipCode,
            Country=location.Country

        });
        _context.SaveChanges();
        return location;
    }
    

    public LocationBase UpdateLocation(LocationBase location)
    {
        var find = _context.Locations.Find(location.Id);
        if (find != null)
        {
            find.Id = location.Id;
            find.State = location.State;
            find.City = location.City;
            find.ZipCode = location.ZipCode;
            find.Country = location.Country;
            _context.SaveChanges();
        }
        return location;
    }

    public bool DeleteLocation(int id)
    {
        var find = _context.Categories.Find(id);
        if (find != null)
        {
            _context.Categories.Remove(find);
            _context.SaveChanges();
            return true;
        }

        return false;
    }

    public Location GetLocationById(int id)
        {
            var find = _context.Locations.Find(id);
            if (find == null) return new Location();
            return new Location()
            {
                Id = find.Id,
                State = find.State ,
                City = find.City ,
                ZipCode = find.ZipCode,
                Country = find.Country 

                
            };    
        }

    

    public List<LocationBase> Locations()
    {
        return _context.Locations.Select(c => new LocationBase()
        {
            Id = c.Id,
            State = c.State,
            City = c.City,
            ZipCode = c.ZipCode,
            Country = c.Country
        }).ToList();
    }
}