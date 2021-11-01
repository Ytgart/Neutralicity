using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CityCatalogue : ICityList
{
    public List<City> _cities {get; set;} = new List<City>();

    public void AddCity(City city)
    {
        _cities.Add(city);
    }

    public void DeleteCity(string name)
    {
        _cities.Remove(_cities.Where(city => city.Name == name).First());
    }

    public void UpdateList()
    {
        foreach (var city in _cities)
        {
            city.CityResources.UpdateValues();
        }
    }
}
