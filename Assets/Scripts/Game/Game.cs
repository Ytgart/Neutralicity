using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private float _tickRate;
    [SerializeField] private GameRender _gameRender;
    private CityCatalogue _cities = new CityCatalogue();

    public Action OnInfoUpdated;

    
    private void Awake()
    {
        
        _cities.AddCity(new City("Забаш", new System.Numerics.Vector2(1,1)));
        _cities.AddCity(new City("Шабаз", new System.Numerics.Vector2(20,1)));
        _cities.AddCity(new City("Забашстан", new System.Numerics.Vector2(1,20)));

        InvokeRepeating("TickGame",  1, _tickRate);

        _gameRender.RenderCities(_cities._cities);

    }

    public void TickGame()
    {
        _cities.UpdateList();
        _gameRender.RenderCitiesGrowth(_cities._cities);
    }
}
