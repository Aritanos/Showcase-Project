using UnityEngine;

namespace Colortribes.FightSystem
{
    public class AnimatorEventScript : MonoBehaviour
    {
        private FightingAI _fightingAI;

        private void Awake()
        {
            _fightingAI = GetComponentInParent<FightingAI>();
        }

        public void TriggerEvent()
        {
            _fightingAI.DoDamage();
        }
    }
}
