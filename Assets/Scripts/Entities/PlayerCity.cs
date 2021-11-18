using UnityEngine;
using Zenject;

public class PlayerCity : City
{
    public override void SpawnUnit()
    {
        var newArmy = _diContainer.InstantiatePrefab(_army, transform.position, Quaternion.identity, null);
        var path = _pathRepository.Paths[1];
        path.Reverse();
        newArmy.GetComponent<Army>().SetNewPath(path);
    }
}
