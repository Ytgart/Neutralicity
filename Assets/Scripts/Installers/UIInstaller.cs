using UnityEngine;
using Zenject;

public class UIInstaller : MonoInstaller
{
    [SerializeField] private ObservePanel _panel;

    public override void InstallBindings()
    {
        Container.Bind<ObservePanel>().FromInstance(_panel).AsSingle();
    }
}