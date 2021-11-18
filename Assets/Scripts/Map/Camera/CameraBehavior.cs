using UnityEngine;
using Zenject;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [Inject] private InputHandler _inputHandler;

    void Update()
    {
        MoveCamera();
    }

    public void MoveCamera() 
    {
        _camera.orthographicSize -= _inputHandler.GetWheelVector().y / 2;
        _camera.orthographicSize = Mathf.Clamp(_camera.orthographicSize, 2, 20);

        if (_inputHandler.MainInput.Main.MouseClickLeft.ReadValue<float>() >= 1)
        {
            _camera.transform.position -= (Vector3)_inputHandler.MainInput.Main.MouseDelta.ReadValue<Vector2>() / 20;
        }
    }
}
