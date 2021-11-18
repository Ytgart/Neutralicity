using System.Collections.Generic;

public interface IResourcesList<T>
{
    public IReadOnlyList<Resource> Resources { get; set; }
    void AddResource(T resource);
    void UpdateValues();
}
