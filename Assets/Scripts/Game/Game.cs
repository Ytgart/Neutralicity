using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class Game : MonoBehaviour
{
    [SerializeField] private GameRender _gameRender;
    [Inject] private Ticker _ticker;

    public ICityList Cities { get; set; } = new CityCatalogue();

    private void Awake()
    {
        _ticker.OnTicked += TickGame;
        Cities.AddCity(new City("Забаш", new System.Numerics.Vector2(1, 1)));
        Cities.AddCity(new City("Шабаз", new System.Numerics.Vector2(20, 1)));
        Cities.AddCity(new City("Забашстан", new System.Numerics.Vector2(1, 20)));

        _gameRender.RenderCities(Cities._cities);
    }

    public void TickGame()
    {
        Cities.UpdateList();
        //_gameRender.RenderCitiesGrowth(_cities._cities);
    }
}
