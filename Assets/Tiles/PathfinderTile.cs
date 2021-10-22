using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Tiles/PathfinderTile")]
public class PathfinderTile : Tile
{
    public TileType Type{get; set;} = TileType.grass;
    public PathData Data{get; private set;}

    // Названия расставленны в порядке веса (от лёгкого к тяжёлому)
    public enum TileType 
    {
        road,
        grass,
        dirt,
        swamp
    }

    public void BecomeNode(int g, Vector3Int target, PathfinderTile previous)
    {
        Data = new PathData(g, target, previous);
    }
}
