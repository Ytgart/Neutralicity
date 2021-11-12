using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

public class UIController : MonoBehaviour
{
    [Inject] private InputHandler _inputHandler; 
    [SerializeField] private List<Panel> _panels = new List<Panel>();
    public IReadOnlyList<Panel> Panels => _panels.AsReadOnly();
    public bool IsHided { get; private set; } = false;

    private void Awake()
    {
        _inputHandler.MainInput.Main.F1Button.performed += HideUI;
    }

    public void HideUI(InputAction.CallbackContext context) 
    {
        foreach (var item in _panels)
        {
            item.SetVisible(IsHided);
        }
        IsHided = !IsHided;
    }
}
