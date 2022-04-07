using UnityEngine;

//управление анимациями
namespace Colortribes.FightSystem
{
    public class DummyAnimator : MonoBehaviour
    {
        [SerializeField] private Animator _anim;

        public void TriggerWalkAnimation()
        {
            _anim.SetTrigger("Walk");
        }

        public void TriggerDeathAnimation()
        {
            _anim.SetTrigger("Death");
        }

        public void ActivateHitAnimation()
        {
            _anim.SetBool("Hit", true);
        }

        public void DisactivateHitAnimation()
        {
            _anim.SetBool("Hit", false);
        }

        public void TriggerIdleAnimation()
        {
            _anim.SetTrigger("Idle");
        }
    }
}
