using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CityUI : MonoBehaviour
{
    [SerializeField] private City _city;
    [SerializeField] private Text _name;
    [SerializeField] private Text _health;
    [Inject] private CameraBehavior _camera;

    private void Awake()
    {
        UpdateSize(_camera.CameraSize);
        _camera.OnSizeChanged += UpdateSize;
    }

    public void UpdateInfo(int newHealth, string newName) 
    {
        _name.text = newName;
        _health.text = newHealth.ToString();
    }

    public void UpdateSize(float newSize) 
    {
        ((RectTransform)transform).localScale = new Vector3(newSize * 0.15f, newSize * 0.15f, newSize * 0.15f);
    }
}
