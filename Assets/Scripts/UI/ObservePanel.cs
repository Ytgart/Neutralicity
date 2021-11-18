using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ObservePanel : Panel
{
    [Inject] private Ticker _ticker;

    private IInteractable _currentObject;

    private void Awake()
    {
        _ticker.OnTicked += UpdateInfo;
    }

    public void SetCurrentObject(IInteractable entity) 
    {
        _currentObject = entity;
        UpdateInfo();
    }

    public void UpdateInfo() 
    {
        if (_currentObject != null) 
        {
            _texts[0].text = _currentObject.GetDataString();
        }
    }
}

