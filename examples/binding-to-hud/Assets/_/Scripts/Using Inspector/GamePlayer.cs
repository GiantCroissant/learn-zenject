namespace ZenjectExample.BindingToHud.UsingInspector
{
    using UnityEngine;
    
    public class GamePlayer : MonoBehaviour
    {
        public int hp;

        public GameHud gameHud;

        void Start()
        {
            gameHud.hpLabel.text = $"{hp}";
        }
    }
}
