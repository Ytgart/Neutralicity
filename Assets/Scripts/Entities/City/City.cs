using System.Collections;
using UnityEngine;
using Zenject;

public class City : GameEntity
{
    [Inject] private IResourcesList<Resource> _resourcesList;
    [Inject] private DiContainer _diContainer;
    [Inject] private PathRepository _pathRepository;
    [SerializeField] private Vector3Int _tilePosition;
    [SerializeField] private GameObject _army;

    public IResourcesList<Resource> ResourcesList => _resourcesList;
    public Vector3Int TilePosition => _tilePosition;

    public void ChangeRelation()
    {

    }

    public override string GetDataString()
    {
        return base.GetDataString() + $"\nGold:{ResourcesList.Resources[0].Amount}\nWood:{ResourcesList.Resources[1].Amount}\nFood:{ResourcesList.Resources[2].Amount}\nPopulation:{ResourcesList.Resources[3].Amount}\n";
    }

    public void SpawnUnit() 
    {
        var newArmy = _diContainer.InstantiatePrefab(_army, transform.position, Quaternion.identity, null);
        newArmy.GetComponent<Army>().SetNewPath(_pathRepository.Paths[1]);
    }
}
