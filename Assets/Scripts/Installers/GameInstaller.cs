using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private Game _game;
    [SerializeField] private Ticker _ticker;
    [SerializeField] private MainInput _mainInput;
    [SerializeField] private InputHandler _inputHandler;

    public override void InstallBindings()
    {
        Container.Bind<Game>().FromInstance(_game).AsSingle();
        Container.Bind<Ticker>().FromInstance(_ticker).AsSingle();
        Container.Bind<MainInput>().FromInstance(_mainInput).AsSingle();
        Container.Bind<InputHandler>().FromInstance(_inputHandler).AsSingle();
    }
}