using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private TileDataRepository _repository;
    [SerializeField] private TilePanel _tilePanel;
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private Pathfinder _pathfinder;
    public MainInput MainInput { get; private set; }

    private void Awake()
    {
        MainInput = new MainInput();
    }

    private void OnEnable()
    {
        MainInput.Enable();
        MainInput.Main.MouseClickRight.performed += GetTileData;
    }

    public Vector2 GetWheelVector()
    {
        return MainInput.Main.MouseWheel.ReadValue<Vector2>().normalized;
    }

    public Vector2 GetMousePosition()
    {
        return MainInput.Main.MousePosition.ReadValue<Vector2>();
    }

    public void GetTileData(InputAction.CallbackContext context)
    {
        var mousePosition = Camera.main.ScreenToWorldPoint((Vector3)MainInput.Main.MousePosition.ReadValue<Vector2>());
        var tilePosition = _tilemap.WorldToCell(mousePosition);
        _tilePanel.ShowTileInfo(_repository.GetTileData(tilePosition));
        _pathfinder.FindPath(tilePosition);

    }
}
