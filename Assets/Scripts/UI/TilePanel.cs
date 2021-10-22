using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TilePanel : MonoBehaviour
{
    [SerializeField] private Pathfinder _pathFinder;
    [SerializeField] private Text _data;

    public void ShowTileInfo(Vector3 position)
    {
        _data.text = _pathFinder.GetTileData(position);
    }
}
