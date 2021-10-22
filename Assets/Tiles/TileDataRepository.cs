using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileDataRepository : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    private Dictionary<Vector3Int, PathData> tileData = new Dictionary<Vector3Int, PathData>();

    private void Start()
    {
        UpdateMap();
    }

    public PathData GetTileData(Vector3Int position)
    {
        if (tileData.ContainsKey(position))
        {
            return tileData[position];
        }
        return null;
    }

    public void UpdateMap()
    {
        foreach (var item in _tilemap.cellBounds.allPositionsWithin)
        {
            if (_tilemap.HasTile(item))
            {
                switch (_tilemap.GetTile(item).name)
                {
                    case "Grass":
                        tileData.Add(item, new PathData(PathData.TileType.grass));
                        break;
                    case "Road":
                        tileData.Add(item, new PathData(PathData.TileType.road));
                        break;
                }

            }
        }
    }
}
