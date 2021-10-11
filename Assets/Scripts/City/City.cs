using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class City : MonoBehaviour, IDamageable, IPointerDownHandler
{
    [SerializeField] private CityPanel _cityPanel;
    [SerializeField] private string _name;

    private ResourcesList _resourcesList = new ResourcesList();

    public ResourcesList CityResources => _resourcesList;
    public int HealthPoints { get; set; } = 100;
    public string Name => _name;

    public void TakeDamage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }

    private void Awake()
    {
        _resourcesList.AddResource(new Resource("Золото", 0, 1));
        _resourcesList.AddResource(new Resource("Древесина", 0, 1));
        _resourcesList.AddResource(new Resource("Еда", 0, 1));
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _cityPanel.SetTargerCity(this);
    }
}
