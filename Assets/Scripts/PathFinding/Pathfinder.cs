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
        (_tilemap.GetTile(new Vector3Int(5,1,0)) as PathfinderTile).Type = PathfinderTile.TileType.road;
        FindPath(new Vector3Int(5,1,0));
    }

    public void FindPath(Vector3Int targetTile)
    {
        (_tilemap.GetTile(new Vector3Int(-20,4,0)) as PathfinderTile).BecomeNode(0, targetTile, null);
        //_tilemap.SetTile(_tilemap.WorldToCell(_baseUnit.transform.position), null);
    }

    public string GetTileData(Vector3 position) 
    {
        var tileCoords = _tilemap.WorldToCell(position);
        var tile = _tilemap.GetTile(tileCoords) as PathfinderTile;
        if (!tile)
        {
            return "Тут тайла нет(";
        }
        if (tile.Data is null)
        {
            return @$"
            Кординаты: x:{tileCoords.x}, y:{tileCoords.y}
            Тип тайла: {tile.Type}
            Modifier={((int)tile.Type)}";
        }
        return @$"
        Кординаты: x:{tileCoords.x}, y:{tileCoords.y}
        Тип тайла: {tile.Type}
        PathData: 
        F={tile.Data.F}
        G={tile.Data.G}
        H={tile.Data.H}
        Modifier={((int)tile.Type)}";
    }
} 
