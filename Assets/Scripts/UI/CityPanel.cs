using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityPanel : MonoBehaviour
{
    [SerializeField] Game _game;
    [SerializeField] private List<Text> _resourceTexts = new List<Text>();

    private City _targetCity;

    public void ShowCityInfo()
    {
        if (_targetCity != null)
        {
            _resourceTexts[0].text = _targetCity.Name;
            _resourceTexts[1].text = $"{_targetCity.CityResources.Resources[0].Amount} (+{_targetCity.CityResources.Resources[0].Growth})";
            _resourceTexts[2].text = $"{_targetCity.CityResources.Resources[1].Amount} (+{_targetCity.CityResources.Resources[1].Growth})";
            _resourceTexts[3].text = $"{_targetCity.CityResources.Resources[2].Amount} (+{_targetCity.CityResources.Resources[2].Growth})";
            _resourceTexts[4].text = $"{_targetCity.HealthPoints} HP";
        }
    }

    public void SetTargerCity(City newCity)
    {
        _targetCity = newCity;
        ShowCityInfo();
    }
}
