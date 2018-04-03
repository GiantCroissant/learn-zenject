namespace ZenjectExample.BindingToHud.UsingBinding
{
    using UnityEngine;
    
    public class GamePlayer : MonoBehaviour
    {
        public int hp;
        
        [Zenject.Inject]
        private void Construct(GameHud gameHud)
        {
            gameHud.hpLabel.text = $"{hp}";
        }
    }
}
