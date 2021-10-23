using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using System;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private Tilemap _renderTilemap;
    [SerializeField] private Tile _tile;
    [SerializeField] private BaseUnit _baseUnit;
    [SerializeField] private TileDataRepository _repository;

    public List<Vector3Int> FindPath(Vector3Int targetTile)
    {
        var pathToTarget = new List<Vector3Int>();
        var checkedTiles = new List<PathData>();
        var waitingTiles = new List<PathData>();

        var tilePosition = _tilemap.WorldToCell(_baseUnit.transform.position);

        var firstTile = CreateNode(0, tilePosition, targetTile, null);
        checkedTiles.Add(_repository.GetTileData(tilePosition));

        _renderTilemap.ClearAllTiles();
        _repository.UpdateMap();

        waitingTiles.AddRange(FindNeighbourTiles(firstTile, checkedTiles));

        while (waitingTiles.Count > 0)
        {
            PathData pathDataToCheck = waitingTiles.Where(x => x.F == waitingTiles.Min(y => y.F)).Last();

            if (pathDataToCheck.Position == targetTile)
            {
                return CalculatePathFromTiles(pathDataToCheck);
            }

            waitingTiles.Remove(pathDataToCheck);
            if (!checkedTiles.Where(x => x.Position == pathDataToCheck.Position).Any())
            {
                checkedTiles.Add(pathDataToCheck);
                waitingTiles.AddRange(FindNeighbourTiles(pathDataToCheck, checkedTiles));
            }
        }
        return pathToTarget;
    }

    private List<Vector3Int> CalculatePathFromTiles(PathData data)
    {
        var resultPath = new List<Vector3Int>();
        var currentTile = data;

        while (currentTile.PreviousTile != null)
        {
            resultPath.Add(currentTile.Position);
            _renderTilemap.SetTile(currentTile.Position, _tile);
            currentTile = currentTile.PreviousTile;
        }
        return resultPath;
    }

    PathData CreateNode(int g, Vector3Int position, Vector3Int targetTile, PathData previous)
    {
        var data = _repository.GetTileData(position);
        data.Position = position;
        data.TargetPosition = targetTile;
        data.PreviousTile = previous;
        data.G = g;
        data.H = (int)Mathf.Abs(targetTile.x - position.x) + (int)Mathf.Abs(targetTile.y - position.y);
        data.F = data.G + data.H + (int)data.Type;
        return data;
    }

    List<PathData> FindNeighbourTiles(PathData tile, List<PathData> checkedTiles)
    {
        var neighbours = new List<PathData>();

        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x + 1, tile.Position.y, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 1, new Vector3Int(tile.Position.x + 1, tile.Position.y, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x - 1, tile.Position.y, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 1, new Vector3Int(tile.Position.x - 1, tile.Position.y, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x, tile.Position.y + 1, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 1, new Vector3Int(tile.Position.x, tile.Position.y + 1, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x, tile.Position.y - 1, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 1, new Vector3Int(tile.Position.x, tile.Position.y - 1, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x + 1, tile.Position.y + 1, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 2, new Vector3Int(tile.Position.x + 1, tile.Position.y + 1, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x - 1, tile.Position.y + 1, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 2, new Vector3Int(tile.Position.x - 1, tile.Position.y + 1, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x + 1, tile.Position.y - 1, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 2, new Vector3Int(tile.Position.x + 1, tile.Position.y - 1, 0), tile.TargetPosition, tile));
        }
        if (!checkedTiles.Where(x => x.Position == new Vector3Int(tile.Position.x - 1, tile.Position.y - 1, 0)).Any())
        {
            neighbours.Add(CreateNode(tile.G + 2, new Vector3Int(tile.Position.x - 1, tile.Position.y - 1, 0), tile.TargetPosition, tile));
        }
        return neighbours;
    }
}
