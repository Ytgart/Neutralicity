using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private TilePanel _tilePanel;
    public MainInput MainInput{get; private set;}

    private void Awake()
    {
        MainInput = new MainInput();
    }

    private void OnEnable() 
    {
        MainInput.Enable();   
        MainInput.Main.MouseClick.performed += GetTileData;
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
        _tilePanel.ShowTileInfo(Camera.main.ScreenToWorldPoint((Vector3)MainInput.Main.MousePosition.ReadValue<Vector2>()));
    }
}
