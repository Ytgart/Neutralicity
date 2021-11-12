using System.Collections.Generic;
using System.Numerics;

public class City : IDamageable, IInteractable
{
    public Vector2 Location { get; set; }
    public ResourcesList CityResources { get; private set; } = new ResourcesList();
    public int HealthPoints { get; set; } = 100;
    public string Name { get; private set; }

    public List<Vector3> housePositions = new List<Vector3>();

    public City(string name, Vector2 location)
    {
        Name = name;
        Location = location;
        CityResources.AddResource(new Resource("Золото", 0, 1));
        CityResources.AddResource(new Resource("Древесина", 0, 1));
        CityResources.AddResource(new Resource("Еда", 0, 1));
        CityResources.AddResource(new Resource("Население", 1, 1));
    }

    public void TakeDamage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }

    public string GetData()
    {
        return $"|ГОРОД|\nИмя: {Name}\nХП:{HealthPoints}\nЗолото: {CityResources.Resources[0].Amount}\nДревисина: {CityResources.Resources[1].Amount}\nЕда: {CityResources.Resources[2].Amount}\nНаселение: {CityResources.Resources[3].Amount}\n ";
    }
}
