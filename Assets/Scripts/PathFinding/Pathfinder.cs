using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Pathfinder : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private BaseUnit _baseUnit;
    [SerializeField] private TileDataRepository _repository;

    void Start()
    {
        FindPath(new Vector3Int(5,1,0));
    }

    public void FindPath(Vector3Int targetTile)
    {
        var data = _repository.GetTileData(_tilemap.WorldToCell(_baseUnit.transform.position));
        data.G = 5;
    }
} 
