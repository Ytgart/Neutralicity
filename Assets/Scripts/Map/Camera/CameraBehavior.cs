using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private InputHandler _inputHandler;

    private Vector3 _targerPosition;

    void Update()
    {
        _camera.orthographicSize -= _inputHandler.GetWheelVector().y / 2;
        _camera.orthographicSize = Mathf.Clamp(_camera.orthographicSize, 5, 20);

        if (_inputHandler.MainInput.Main.MouseClickLeft.ReadValue<float>() >= 1)
        {
            _camera.transform.position -= (Vector3)_inputHandler.MainInput.Main.MouseDelta.ReadValue<Vector2>() / 20;
        }
    }
}
