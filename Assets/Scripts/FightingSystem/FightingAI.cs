using UnityEngine;

//Dummy AI
namespace Colortribes.FightSystem
{
    public class FightingAI : MonoBehaviour
    {
        private IColorable _targetColorable = null;

        private DummyPathFInder _pathFinder;
        private DummyAnimator _anim;
        private Transform _target;

        private ColorType _colorType;

        public void AwakeAI(ColorType colorType, Transform target)
        {
            _colorType = colorType;
            _target = target;
            _pathFinder.SetTarget(_target);
            _anim.TriggerWalkAnimation();
            enabled = true;
        }

        public void SetWinCondition()
        {
            _anim.TriggerIdleAnimation();
            DisableAI();
        }

        public void SetDeathCondition()
        {
            _anim.TriggerDeathAnimation();
            DisableAI();
        }

        public void DoDamage()
        {
            _targetColorable?.Damage();
        }

        private void DisableAI()
        {
            _pathFinder.DisableNavigation();
            enabled = false;
        }

        private void Awake()
        {
            _anim = GetComponent<DummyAnimator>();
            _pathFinder = GetComponent<DummyPathFInder>();
            enabled = false;
        }

        private void FindNewColorable()
        {
            _targetColorable = LevelHandler.CurrentLevel.DummyRepository.GetNearestColorable(_colorType, transform.position);
            if (_targetColorable != null)
            {
                _pathFinder.SetTarget(_targetColorable.Transform);
                _targetColorable.DestroyDummy += SwitchColorable;
            }
        }

        private void SwitchColorable(Dummy dummy)
        {
            _targetColorable.DestroyDummy -= SwitchColorable;
            FindNewColorable();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (GameHandler.CurrentGamePhase == GamePhase.Fighting)
            {
                if (other.transform == _target)
                {
                    FindNewColorable();
                }
                else if (_targetColorable != null)
                {
                    _anim.ActivateHitAnimation();
                }
            }
        }
    }
}
