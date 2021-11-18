using System;
using UnityEngine;
using Zenject;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [Inject] private InputHandler _inputHandler;

    public Action<float> OnSizeChanged;

    public float CameraSize
    {
        get => _camera.orthographicSize;
        set
        {
            _camera.orthographicSize = value;
            OnSizeChanged(_camera.orthographicSize);
        }
    }

    void Update()
    {
        MoveCamera();
    }

    public void MoveCamera()
    {
        if (_inputHandler.GetWheelVector().y != 0)
        {
            CameraSize -= _inputHandler.GetWheelVector().y / 2;
            CameraSize = Mathf.Clamp(_camera.orthographicSize, 2, 20);
        }

        if (_inputHandler.MainInput.Main.MouseClickLeft.ReadValue<float>() >= 1)
        {
            _camera.transform.position -= (Vector3)_inputHandler.MainInput.Main.MouseDelta.ReadValue<Vector2>() / 20;
        }
    }
}
