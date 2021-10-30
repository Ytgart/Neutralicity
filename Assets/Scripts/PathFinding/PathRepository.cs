using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PathRepository : MonoBehaviour
{
    private Pathfinder _pathFinder = new Pathfinder();

    public async void RequestPath(Vector3Int start, Vector3Int target, Dictionary<System.Numerics.Vector2, float> weightMatrix, Action<List<System.Numerics.Vector2>> callback)
    {
        List<System.Numerics.Vector2> path = null;
        await Task.Run(() =>
        {
            _pathFinder.FindPath
            (
                new System.Numerics.Vector2(start.x, start.y),
                new System.Numerics.Vector2(target.x, target.y),
                weightMatrix,
                out path
            );
        });
        if (callback != null)
        {
            callback(path);
        }
    }
}
