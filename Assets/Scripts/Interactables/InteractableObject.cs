using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class InteractableObject : MonoBehaviour, IInteractable, IPointerDownHandler
{
    [Inject] private ObservePanel _panel;

    public InteractableType Type { get; set ; }
    public int Index { get; set; }

    public void OnPointerDown(PointerEventData eventData)
    {
        _panel.ShowInfo(this);
    }
}
