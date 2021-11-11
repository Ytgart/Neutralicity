using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class Game : MonoBehaviour
{
    [SerializeField] private GameRender _gameRender;
    [SerializeField] private Ticker _ticker;
    [SerializeField] private Text _text;

    [Inject] public ICityList _cities { get; set; }

    private void Awake()
    {
        _ticker.OnTicked += TickGame;
        _cities.AddCity(new City("Забаш", new System.Numerics.Vector2(1, 1)));
        _cities.AddCity(new City("Шабаз", new System.Numerics.Vector2(20, 1)));
        _cities.AddCity(new City("Забашстан", new System.Numerics.Vector2(1, 20)));
    }

    public void TickGame()
    {
        _cities.UpdateList();
        //_gameRender.RenderCitiesGrowth(_cities._cities);
    }
}
