using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class Map : MonoBehaviour
{
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private PathRepository _pathRepository;

    private Action<List<System.Numerics.Vector2>> OnPathFinded;

    private void OnEnable()
    {
        _inputHandler.MainInput.Main.MouseClickRight.performed += FindPath;
        OnPathFinded += UpdateMap;
    }

    public Dictionary<System.Numerics.Vector2, float> GetTileWeights()
    {
        var result = new Dictionary<System.Numerics.Vector2, float>();
        foreach (var item in _tilemap.cellBounds.allPositionsWithin)
        {
            if (_tilemap.HasTile(item))
            {
                switch (_tilemap.GetTile(item).name)
                {
                    case "grass":
                        result.Add(new System.Numerics.Vector2(item.x, item.y), 20);
                        break;
                    case "road":
                        result.Add(new System.Numerics.Vector2(item.x, item.y), 0);
                        break;
                    case "pathless":
                        result.Add(new System.Numerics.Vector2(item.x, item.y), 999);
                        break;
                }
            }
        }
        return result;
    }

    public void FindPath(InputAction.CallbackContext context)
    {
        var mousePos = _inputHandler.MainInput.Main.MousePosition.ReadValue<Vector2>();
        var tileWorldPos = Camera.main.ScreenToWorldPoint(mousePos);
        var tilePos = _tilemap.WorldToCell(tileWorldPos);

        _pathRepository.RequestPath(new Vector3Int(0, 0, 0), tilePos, GetTileWeights(), OnPathFinded);
    }

    private void UpdateMap(List<System.Numerics.Vector2> path)
    {
        foreach (var item in path)
        {
            _tilemap.SetColor(new Vector3Int((int)item.X, (int)item.Y, 0), Color.green);
        }
    }
}
