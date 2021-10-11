using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private float _tickRate;
    [SerializeField] private List<City> _cities = new List<City>();

    public Action OnInfoUpdated;

    private void Awake()
    {
        InvokeRepeating("TickGame", _tickRate, 1);
    }

    public void TickGame()
    {
        foreach (var item in _cities)
        {
            item.CityResources.UpdateValues();
        }
        OnInfoUpdated.Invoke();
    }
}
