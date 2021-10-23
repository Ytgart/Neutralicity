using UnityEngine;
using UnityEngine.Tilemaps;

public class PathData
{
    public PathData(TileType type)
    {
        Type = type;
    }

    public PathData(int g, TileType type, Vector3Int position, Vector3Int targetPosition, PathData previousTile)
    {
        G = g;
        Type = type;
        Position = position;
        TargetPosition = targetPosition;
        PreviousTile = previousTile;
    }

    public TileType Type { get; set; } = TileType.grass;
    public Vector3Int Position { get; set; }
    public Vector3Int TargetPosition { get; set; }
    public PathData PreviousTile { get; set; }
    public int F { get; set; } = 0;
    public int G { get; set; } = 0;
    public int H { get; set; } = 0;

    public enum TileType
    {
        road = 0,
        grass = 5,
        dirt = 7,
        swamp = 10,
        rock = 15,
        pathless = 999
    }
}
