using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathData
{
    public PathData(int g,Vector3Int targetPosition, PathfinderTile previousTile)
    {
        G = g;
        TargetPosition = targetPosition;
        PreviousTile = previousTile;
    }

    public Vector3Int TargetPosition {get; set;}
    public PathfinderTile PreviousTile {get; set;}
    public int F {get; set;} = 0;
    public int G {get; set;} = 0;
    public int H {get; set;} = 0;
}
