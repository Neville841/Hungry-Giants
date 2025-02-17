using Zenject;
using UnityEngine;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<AiManager>().FromComponentInHierarchy().AsSingle();
        Debug.Log(Container.Resolve<AiManager>() != null ? "AiManager bulundu!" : "AiManager bulunamadý!");

    }
}