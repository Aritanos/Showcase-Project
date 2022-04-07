using UnityEngine;
using System;

//Dummy объект
namespace Colortribes.FightSystem
{
    public class Dummy : MonoBehaviour, IColorable
    {
        [SerializeField] private SkinnedMeshRenderer _dummyRenderer;
        [SerializeField] private FightingAI _fightingAI;
        [SerializeField] private ColorType _initialColorType;

        public ColorType ColorType { get; private set; }
        public Transform Transform => transform;
        public event Action<Dummy> DestroyDummy;

        private void Start()
        {
            ColorType = _initialColorType;
        }

        public void ChangeColor(ColorType colorType)
        {
            ColorType = colorType;
            _dummyRenderer.material = Containers.MaterialsContainer.Get[ColorType];
        }

        public void StartFight()
        {
            if (!CheckIfDead())
            {
                _fightingAI.AwakeAI(ColorType, LevelHandler.CurrentLevel.FightingPosition);
            }
        }

        public void Damage()
        {
            KillThisDummy();
        }

        private void KillThisDummy()
        {
            DestroyDummy?.Invoke(this);
            _fightingAI.SetDeathCondition();
        }

        private bool CheckIfDead()
        {
            if (ColorType == ColorType.Neutral)
            {
                KillThisDummy();
                return true;
            }
            return false;
        }

        public void SetWinCondition()
        {
            _fightingAI.SetWinCondition();
        }
    }
}
