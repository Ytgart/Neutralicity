using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

public class PathRepository : MonoBehaviour
{
    private Pathfinder _pathFinder = new Pathfinder();
    private Dictionary<int, List<System.Numerics.Vector2>> _paths
        = new Dictionary<int, List<System.Numerics.Vector2>>();
    private int _pathID = 1;

    private Action<List<System.Numerics.Vector2>> OnPathCreated;
    [Inject] private Game _game;
    [Inject] private Map _map;

    public IReadOnlyDictionary<int, List<System.Numerics.Vector2>> Paths => _paths;

    private void Awake()
    {
        OnPathCreated += AddPath;
        FindPaths();
    }

    private async void RequestPath(Vector3Int start, Vector3Int target, Dictionary<System.Numerics.Vector2, float> weightMatrix, Action<List<System.Numerics.Vector2>> callback)
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

    public void FindPaths()
    {
        _pathID = 1;
        for (int i = 1; i < _game.Cities.Count; i++)
        {
            RequestPath(_game.Cities[0].TilePosition, _game.Cities[i].TilePosition, _map.GetTileWeights(), OnPathCreated);
        }
    }

    public void AddPath(List<System.Numerics.Vector2> path)
    {
        path.Reverse();
        _paths.Add(_pathID, path);
        Debug.Log($"Путь найден {_pathID}");
        _pathID++;
    }
}
