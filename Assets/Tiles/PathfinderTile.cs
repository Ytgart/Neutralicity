using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Tiles/PathfinderTile")]
public class PathfinderTile : Tile
{
    public TileType Type{get; set;} = 0;

    public enum TileType
    {
        grass,
        road
    }
}
