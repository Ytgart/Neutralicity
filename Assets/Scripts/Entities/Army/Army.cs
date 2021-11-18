using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.Tilemaps;

public class Army : GameEntity
{
    private List<System.Numerics.Vector2> _path;
    private int currentTile = 0;
    [Inject] private Tilemap _tilemap;
    [Inject] private Ticker _ticker;
    [SerializeField] private List<Unit> _units = new List<Unit>();

    private void Awake()
    {
        _ticker.OnTicked += MoveToNextCell;
    }

    public void MoveToCell(Vector3Int position)
    {
        var tileCenterPosition = _tilemap.GetCellCenterWorld(position);

        transform.position = tileCenterPosition;
    }

    private void MoveToNextCell()
    {
        if (!(currentTile == _path.Count))
        {
            MoveToCell(new Vector3Int((int)_path[currentTile].X, (int)_path[currentTile].Y, 0));
            currentTile++;
        }
    }

    public void SetNewPath(List<System.Numerics.Vector2> newPath)
    {
        _path = newPath;
    }
}
