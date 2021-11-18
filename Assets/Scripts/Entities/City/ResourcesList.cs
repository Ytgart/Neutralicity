using System.Collections.Generic;

public class ResourcesList : IResourcesList<Resource>
{
    private List<Resource> _resources = new List<Resource>();

    public ResourcesList()
    {
        AddResource(new Resource("������", 0, 1));
        AddResource(new Resource("���������", 0, 1));
        AddResource(new Resource("���", 0, 1));
        AddResource(new Resource("���������", 1, 1));
    }

    public IReadOnlyList<Resource> Resources { get => _resources.AsReadOnly(); set { } }

    public void AddResource(Resource resource)
    {
        _resources.Add(resource);
    }

    public void UpdateValues()
    {
        foreach (var item in _resources)
        {
            item.AddGrowthValue();
        }
    }
}
