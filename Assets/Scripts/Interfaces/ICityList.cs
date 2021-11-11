using System.Collections;
using System.Collections.Generic;

public interface ICityList
{
    List<City> _cities {get; set;}

    void AddCity (City city);

    void DeleteCity(string name);

    void UpdateList();
}
