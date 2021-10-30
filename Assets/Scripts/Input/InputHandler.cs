using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class InputHandler : MonoBehaviour
{
    public MainInput MainInput { get; private set; }

    private void Awake()
    {
        MainInput = new MainInput();
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
}
