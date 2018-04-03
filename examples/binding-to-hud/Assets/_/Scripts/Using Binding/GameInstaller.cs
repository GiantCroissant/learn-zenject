namespace ZenjectExample.BindingToHud.UsingBinding
{
    public class GameInstaller : Zenject.MonoInstaller
    {
        public GameHud gameHud;

        public GamePlayer gamePlayer;
        
        public override void InstallBindings()
        {
            Container.BindInstance(gameHud);
            
            Container.QueueForInject(gamePlayer);
        }
    }
}