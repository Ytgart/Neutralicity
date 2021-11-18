using UnityEngine;
using UnityEngine.Tilemaps;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Game _game;
    [SerializeField] private Ticker _ticker;
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private Tilemap _tilemap;
    [SerializeField] private Map _map;
    [SerializeField] private PathRepository _pathRepository;

    public override void InstallBindings()
    {
        Container.Bind<Game>().FromInstance(_game).AsSingle();
        Container.Bind<Ticker>().FromInstance(_ticker).AsSingle();
        Container.Bind<InputHandler>().FromInstance(_inputHandler).AsSingle();
        Container.Bind<Tilemap>().FromInstance(_tilemap).AsSingle();
        Container.Bind<Map>().FromInstance(_map).AsSingle();
        Container.Bind<PathRepository>().FromInstance(_pathRepository).AsSingle();
        Container.Bind<IResourcesList<Resource>>().To<ResourcesList>().FromNew().AsTransient();
    }
}