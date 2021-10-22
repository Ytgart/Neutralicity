using UnityEngine;
using UnityEngine.Tilemaps;

public class PathData
{
    public PathData(TileType type)
    {
        Type = type;
    }

    public PathData(int g, TileType type, Vector3Int targetPosition, Tile previousTile)
    {
        G = g;
        Type = type;
        TargetPosition = targetPosition;
        PreviousTile = previousTile;
    }

    public TileType Type { get; set; } = TileType.grass;
    public Vector3Int TargetPosition { get; set; }
    public Tile PreviousTile { get; set; } = null;
    public int F { get; set; } = 0;
    public int G { get; set; } = 0;
    public int H { get; set; } = 0;

    public enum TileType
    {
        road,
        grass,
        dirt,
        swamp
    }
}
