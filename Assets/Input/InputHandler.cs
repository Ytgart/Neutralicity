using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public MainInput MainInput{get; private set;}

    private void Awake()
    {
        MainInput = new MainInput();
    }

    private void OnEnable() 
    {
        MainInput.Enable();   
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
