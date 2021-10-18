using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private BaseUnit _baseUnit;

    void Start()
    {
        foreach (var position in _tilemap.cellBounds.allPositionsWithin)
        {
            if (_tilemap.HasTile(position))
            {
                if ((_tilemap.GetTile(position) as PathfinderTile).name == "Road")
                {
                    (_tilemap.GetTile(position) as PathfinderTile).Type = PathfinderTile.TileType.road;
                 }
            }
        }
    }

    public void FindPath()
    {

        
    }
}
