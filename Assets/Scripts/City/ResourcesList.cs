using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesList
{
    private List<Resource> resources = new List<Resource>();
    public IList<Resource> Resources => resources.AsReadOnly();

    public void AddResource(Resource resource)
    {
        resources.Add(resource);
    }

    public void UpdateValues()
    {
        foreach (var item in resources)
        {
            item.AddGrowthValue();
        }
    }
}
