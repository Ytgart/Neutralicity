using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;
using Zenject;

public class InputHandler : MonoBehaviour
{
    [Inject] private Tilemap _tilemap;

    public MainInput MainInput { get; private set; }

    private void Awake()
    {
        MainInput = new MainInput();
        //MainInput.Main.MouseClickLeft.performed += ShowCoordinates;
    }

    private void OnEnable()
    {
        MainInput.Enable();
    }

    private void OnDisable()
    {
        MainInput.Disable();
    }

    public Vector2 GetWheelVector()
    {
        return MainInput.Main.MouseWheel.ReadValue<Vector2>().normalized;
    }

    public Vector2 GetMousePosition()
    {
        return MainInput.Main.MousePosition.ReadValue<Vector2>();
    }

    public void ShowCoordinates(InputAction.CallbackContext context)
    {
        var mousePos = Camera.main.ScreenToWorldPoint(MainInput.Main.MousePosition.ReadValue<Vector2>());
        var tilePos = _tilemap.WorldToCell(new Vector3(mousePos.x, mousePos.y, 0));
        Debug.Log(tilePos);
    }
}
