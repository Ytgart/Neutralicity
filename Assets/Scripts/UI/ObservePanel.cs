using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ObservePanel : Panel
{
    [Inject] private Game _game;
    [Inject] private Ticker _ticker;

    private InteractableObject _currentObject;

    private void Awake()
    {
        _ticker.OnTicked += ShowInfo;
    }

    public void SetObject(InteractableObject newObject)
    {
        _currentObject = newObject;
        ShowInfo();
    }

    private void ShowInfo()
    {
        if (_currentObject != null)
        {
            switch (_currentObject.Type)
            {
                case InteractableType.city:
                    _texts[0].text = _game.Cities._cities[_currentObject.Index].GetData();
                    break;
                case InteractableType.unit:
                    break;
                case InteractableType.structure:
                    break;
                default:
                    break;
            }
        }
    }
}
