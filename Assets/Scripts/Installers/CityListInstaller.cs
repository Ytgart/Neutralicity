using UnityEngine;
using Zenject;

public class CityListInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ICityList>().FromInstance(new CityCatalogue()).AsSingle();
    }
}