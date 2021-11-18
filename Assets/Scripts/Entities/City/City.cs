using UnityEngine;
using Zenject;

public class City : GameEntity
{
    [Inject] protected IResourcesList<Resource> _resourcesList;
    [Inject] protected DiContainer _diContainer;
    [Inject] protected PathRepository _pathRepository;
    [SerializeField] protected Vector3Int _tilePosition;
    [SerializeField] protected GameObject _army;
    [SerializeField] protected CityUI _cityUI;

    public IResourcesList<Resource> ResourcesList => _resourcesList;
    public Vector3Int TilePosition => _tilePosition;

    private void Awake()
    {
        _cityUI.UpdateInfo(HealthPoints, Name);
    }

    public void ChangeRelation()
    {

    }

    public override string GetDataString()
    {
        // TODO: add enum
        return base.GetDataString() + $"\nGold:{ResourcesList.Resources[0].Amount}\nWood:{ResourcesList.Resources[1].Amount}\nFood:{ResourcesList.Resources[2].Amount}\nPopulation:{ResourcesList.Resources[3].Amount}\n";
    }

    public virtual void SpawnUnit() 
    {
        var newArmy = _diContainer.InstantiatePrefab(_army, transform.position, Quaternion.identity, null);
        newArmy.GetComponent<Army>().SetNewPath(_pathRepository.Paths[1]);
    }
}
