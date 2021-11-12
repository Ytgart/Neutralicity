using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class InteractableObject : MonoBehaviour, IPointerDownHandler
{
    [Inject] private UIController _controller;

    public InteractableType Type { get; set ; }
    public int Index { get; set; }

    public void OnPointerDown(PointerEventData eventData)
    {
        (_controller.Panels[1] as ObservePanel).SetObject(this);
    }
}
