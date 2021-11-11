using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class Map : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private PathRepository _pathRepository;

    private Action<List<System.Numerics.Vector2>> OnPathFinded;

    public Dictionary<System.Numerics.Vector2, float> GetTileWeights()
    {
        var result = new Dictionary<System.Numerics.Vector2, float>();
        foreach (var item in _tilemap.cellBounds.allPositionsWithin)
        {
            if (_tilemap.HasTile(item))
            {
                switch (_tilemap.GetTile(item).name)
                {
                    case "grass":
                        result.Add(new System.Numerics.Vector2(item.x, item.y), 20);
                        break;
                    case "road":
                        result.Add(new System.Numerics.Vector2(item.x, item.y), 0);
                        break;
                    case "pathless":
                        result.Add(new System.Numerics.Vector2(item.x, item.y), 999);
                        break;
                }
            }
        }
        return result;
    }
}
