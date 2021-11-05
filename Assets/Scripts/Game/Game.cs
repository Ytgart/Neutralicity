using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private GameRender _gameRender;
    [SerializeField] private Ticker _ticker;
    [SerializeField] private Text _text;

    private CityCatalogue _cities = new CityCatalogue();

    private void Awake()
    {
        _ticker.OnTicked += TickGame;
        _cities.AddCity(new City("Забаш", new System.Numerics.Vector2(1, 1)));
        _cities.AddCity(new City("Шабаз", new System.Numerics.Vector2(20, 1)));
        _cities.AddCity(new City("Забашстан", new System.Numerics.Vector2(1, 20)));

        _gameRender.RenderCities(_cities._cities);
    }

    public void TickGame()
    {
        _cities.UpdateList();
        //_gameRender.RenderCitiesGrowth(_cities._cities);
    } 
}
