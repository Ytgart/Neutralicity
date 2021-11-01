using System.Collections;
using System.Collections.Generic;
using System.Numerics;

public class City : IDamageable
{
    private ResourcesList _resourcesList = new ResourcesList();
    private string _name;
    public Vector2 Location { get; set; }
    public ResourcesList CityResources => _resourcesList;
    public int HealthPoints { get; set; } = 100;
    public string Name => _name;

    public List<Vector3> housePositions = new List<Vector3>();
     

    public City(string name, Vector2 location)
    {
        _name = name;
        Location = location;
        _resourcesList.AddResource(new Resource("Золото", 0, 1));
        _resourcesList.AddResource(new Resource("Древесина", 0, 1));
        _resourcesList.AddResource(new Resource("Еда", 0, 1));
        _resourcesList.AddResource(new Resource("Население", 1, 1));
    }

    public void TakeDamage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }
}
