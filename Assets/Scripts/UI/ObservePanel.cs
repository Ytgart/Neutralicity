using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ObservePanel : MonoBehaviour
{
    [Inject] private Game _game;
    [SerializeField] private Text _text;

    public void ShowInfo(IInteractable clickedObject) 
    {
        _text.text = _game._cities._cities[clickedObject.Index].Name;
    }
}
