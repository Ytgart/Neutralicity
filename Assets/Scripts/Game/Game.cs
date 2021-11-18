using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Game : MonoBehaviour
{
    [Inject] private Ticker _ticker;

    [SerializeField] private List<City> _cities = new List<City>();

    public IReadOnlyList<City> Cities => _cities.AsReadOnly();

    private void Awake()
    {
        _ticker.OnTicked += TickGame;
    }

    public void TickGame()
    {
        foreach (var item in _cities)
        {
            item.ResourcesList.UpdateValues();
        }
    }
}
