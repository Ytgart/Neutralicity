using UnityEngine;
using Zenject;
using System.Collections.Generic;

public class PlayerCity : City
{
    public override void SpawnUnit()
    {
        var newArmy = _diContainer.InstantiatePrefab(_army, transform.position, Quaternion.identity, null);
        var path = new List<System.Numerics.Vector2>(_pathRepository.Paths[1]);
        path.Reverse();
        newArmy.GetComponent<Army>().SetNewPath(path);
    }
}
