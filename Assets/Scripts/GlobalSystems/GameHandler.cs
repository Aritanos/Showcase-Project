using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Colortribes.ShootSystem;

namespace Colortribes
{
    //контроль глобальных состояний и запуск ключевых объектов
    public class GameHandler : MonoBehaviour
    {
        public static GamePhase CurrentGamePhase;
        public static Transform DefaultParent;

        [SerializeField] private Transform _defaultParent;
        [SerializeField] private ShootingAI _shootingAI;
        [SerializeField] private Containers _containers;
        [SerializeField] private LevelHandler _levelHandler;

        public void ChangeGamePhase()
        {
            TranslateToNextPhase();
            if (CurrentGamePhase == GamePhase.Shooting)
            {
                _shootingAI.AwakeShooterAI();
                return;
            }
            else if (CurrentGamePhase == GamePhase.Fighting)
            {
                LevelHandler.CurrentLevel.StartFighting(2);
                return;
            }
        }

        public void TranslateToNextPhase()
        {
            if (CurrentGamePhase == GamePhase.End)
            {
                CurrentGamePhase = GamePhase.Start;
            }
            else
            {
                CurrentGamePhase++;
            }
        }

        void Awake()
        {
            CurrentGamePhase = GamePhase.Start;
            DefaultParent = _defaultParent;
            _containers.Init();
            _levelHandler.LoadLevel(0);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeGamePhase();
            }
        }
    }
}
